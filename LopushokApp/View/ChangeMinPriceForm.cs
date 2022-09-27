using LopushokApp.Models;
using LopushokApp.Utilities;
using LopushokApp.View.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokApp.View
{
    public partial class ChangeMinPriceForm : Form
    {
        List<Product> products = new List<Product>();
        List<ProductCard> cards;
        List<decimal> prices = new List<decimal>();
        public ChangeMinPriceForm(List<ProductCard> cardsParam)
        {
            InitializeComponent();

            cards = cardsParam;

            costNumeric.Maximum = Int32.MaxValue;
            costNumeric.Minimum = Int32.MinValue;
        }

        private void ChangeMinPriceForm_Load(object sender, EventArgs e)
        {
            foreach (ProductCard card in cards)
            {
                products.Add(DBContext.Context.Product
                    .First(item => item.ID.ToString() == card.idLabel.Text));
            }
            foreach (Product product in products)
            {
                prices.Add(product.MinCostForAgent);
            }

            costNumeric.Value = prices.Average();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (Product product in products)
            {
                product.MinCostForAgent += costNumeric.Value;
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
