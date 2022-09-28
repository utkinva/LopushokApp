using LopushokApp.Models;
using LopushokApp.Properties;
using LopushokApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokApp.View
{
    public partial class AddEditForm : Form
    {
        Product product { get; set; } = null;
        public AddEditForm(Product productParam)
        {
            InitializeComponent();

            
            if (productParam != null)
            {
                product = productParam;

                articleNumberTextBox.Enabled = false;
            }
            else
            {
                product = new Product()
                {
                    Image = @"..\..\Resources\picture.png"
                };
                addMaterialBtn.Enabled = false;
                deleteMaterialBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }


            minCostForAgentNumericUpDown.Maximum = Int32.MaxValue;
            productionPersonCountNumericUpDown.Maximum = Int32.MaxValue;
            productionWorkshopNumberNumericUpDown.Maximum = Int32.MaxValue;


            productTypeBindingSource.DataSource = DBContext.Context.ProductType.ToList();
            materialBindingSource.DataSource = DBContext.Context.Material.ToList();
        }
        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (product != null)
            {
                if (product.Image == null)
                {
                    imagePictureBox.ImageLocation = @"..\..\Resources\picture.png";
                }
                else
                {
                    imagePictureBox.ImageLocation = product.Image;
                }

                productBindingSource.Add(product);
                GetMaterialList();
            }
            else
            {
                productBindingSource.AddNew();
            }


        }
        private void GetMaterialList()
        {
            var materials = DBContext.Context.ProductMaterial.ToList();

            materials = materials
                .Where(x => x.ProductID == product.ID)
                .ToList();

            productMaterialBindingSource.DataSource = materials;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (product.Sales > 0)
            {
                MessageBox.Show($"Удаление невозможно: у продукции имеются продажи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show($"Удалить данные о продукте?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DBContext.Context.Product.Remove(product);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show($"Данные сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
                errors.AppendLine("Наименование");
            if (productTypeIDComboBox.SelectedItem == null)
                errors.AppendLine("Тип продукции");
            if (String.IsNullOrWhiteSpace(articleNumberTextBox.Text))
                errors.AppendLine("Артикль");

            if (errors.Length > 0)
            {
                MessageBox.Show($"Необходимо заполнить следующие поля:\n{errors}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.ID == 0
                && DBContext.Context.Product
                .FirstOrDefault(x => x.ArticleNumber.ToString() == product.ArticleNumber.ToString()) != null)
            {
                MessageBox.Show($"Продукт с таким артиклем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.ID == 0)
            {
                DBContext.Context.Product.Add(product);
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show($"Данные сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void changeImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory + @"\products\";

            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string file = dialog.FileName;
                int num = file.IndexOf("products");
                file = file.Substring(num);

                imagePictureBox.Image = Image.FromFile(file);
                ((Product)productBindingSource.Current).Image = file;
            }
        }

        private void addMaterialBtn_Click(object sender, EventArgs e)
        {
            AddProductMaterialForm add = new AddProductMaterialForm(product);
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                GetMaterialList();
            }
        }

        private void deleteMaterialBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Удалить данные о материале?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    DBContext.Context.ProductMaterial.Remove((ProductMaterial)productMaterialBindingSource.Current);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show($"Данные сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMaterialList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }


    }
}
