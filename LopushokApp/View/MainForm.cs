using LopushokApp.Models;
using LopushokApp.Utilities;
using LopushokApp.View;
using LopushokApp.View.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokApp
{
    public partial class MainForm : Form
    {
        List<Product> products;
        List<ProductCard> selectedCards = new List<ProductCard>();
        int nPage = 0;
        int nPageMax = 0;
        public MainForm()
        {
            InitializeComponent();

            List<ProductType> types = DBContext.Context.ProductType.ToList();
            types.Insert(0, new ProductType { Title = "Все типы" });
            filterComboBox.DataSource = types;

            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;

            products = DBContext.Context.Product.ToList();

            ApplyFilters();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="products">Список продуктов из таблицы базы данных</param>
        /// <param name="nPage">Текущая страница</param>
        /// <param name="pageSize">Количество элементов на одной странице</param>
        private void GenerateProductCards(List<Product> products, int nPage, int pageSize)
        {
            nPageMax = (int)products.Count / 20 < 1 ? 1 : (int)products.Count / 20;
            products = products.Skip(nPage * pageSize).Take(pageSize).ToList();
            pagesLbl.Text = $"{nPage + 1} из {nPageMax}";

            flowLayoutPanel.Controls.Clear();
            foreach (Product product in products)
            {
                ProductCard card = new ProductCard();
                card.GenerateProductData(product);
                flowLayoutPanel.Controls.Add(card);

                card.DoubleClick += Card_DoubleClick;
                card.Click += Card_Click;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            ProductCard card = sender as ProductCard;

            if (card.BackColor == Color.White)
            {
                selectedCards.Add(card);
                card.BackColor = Color.FromArgb(0, 204, 118);
                card.materialsLabel.BackColor = Color.FromArgb(0, 204, 118);
            }
            else
            {
                selectedCards.Remove(card);
                card.BackColor = Color.White;
                card.materialsLabel.BackColor = Color.White;
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            ProductCard card = sender as ProductCard;

            AddEditForm edit = new AddEditForm(DBContext.Context.Product
                .First(item => item.ID.ToString() == card.idLabel.Text));
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedCards.Clear();
                ApplyFilters();
            }
        }

        /// <summary>
        /// Метод поиска, сортировки и фильтрации
        /// </summary>
        private void ApplyFilters()
        {
            List<Product> updatedList = DBContext.Context.Product.ToList();

            #region Поиск
            if (!String.IsNullOrWhiteSpace(searchTextBox.Text)
                && searchTextBox.Text != "Введите для поиска")
                updatedList = updatedList
                    .Where(item => item.Title.ToLower().Contains(searchTextBox.Text.ToLower())
                    || item.Description.ToLower().Contains(searchTextBox.Text.ToLower()))
                    .ToList();
            #endregion
            #region Сортировка
            if (sortComboBox.SelectedIndex > 0)
                switch (sortComboBox.SelectedIndex)
                {
                    case 1:
                        if (!descCheckBox.Checked)
                            updatedList = updatedList.OrderBy(item => item.Title).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(item => item.Title).ToList();
                        break;
                    case 2:
                        if (!descCheckBox.Checked)
                            updatedList = updatedList.OrderBy(item => item.ProductionWorkshopNumber).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(item => item.ProductionWorkshopNumber).ToList();
                        break;
                    case 3:
                        if (!descCheckBox.Checked)
                            updatedList = updatedList.OrderBy(item => item.MinCostForAgent).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(item => item.MinCostForAgent).ToList();
                        break;
                }
            #endregion
            #region Фильтрация
            if (filterComboBox.SelectedIndex > 0)
                updatedList = updatedList
                    .Where(item => item.ProductTypeID == (filterComboBox.SelectedItem as ProductType).ID)
                    .ToList();
            #endregion

            selectedCards.Clear();
            flowLayoutPanel.Controls.Clear();
            GenerateProductCards(updatedList, nPage, 20);
        }
        /// <summary>
        /// Вызывает метод ApplyFilters для применения выбранных фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriggerFilters(object sender, EventArgs e)
        {
            nPage = 0;
            ApplyFilters();

        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTextBox.Text))
                searchTextBox.Text = "Введите для поиска";
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Введите для поиска")
                searchTextBox.Text = String.Empty;
        }

        private void changePrice_Click(object sender, EventArgs e)
        {
            if (selectedCards.Count >= 1)
            {
                ChangeMinPriceForm changePrice = new ChangeMinPriceForm(selectedCards);
                DialogResult dr = changePrice.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    selectedCards.Clear();
                    ApplyFilters();
                }
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного элемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            AddEditForm add = new AddEditForm(null);
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedCards.Clear();
                ApplyFilters();
            }
        }

        private void nextPageLbl_Click(object sender, EventArgs e)
        {
            if (nPage + 1 < nPageMax)
            {
                nPage++;
                ApplyFilters();
            }
        }

        private void prevPageLbl_Click(object sender, EventArgs e)
        {
            if (nPage > 0)
            {
                nPage--;
                ApplyFilters();
            }
        }
    }
}
