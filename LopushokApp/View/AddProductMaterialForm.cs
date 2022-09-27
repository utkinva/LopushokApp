using LopushokApp.Models;
using LopushokApp.Utilities;
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
    public partial class AddProductMaterialForm : Form
    {
        Product product;
        public AddProductMaterialForm(Product productParam)
        {
            InitializeComponent();

            countNumericUpDown.Maximum = Int32.MaxValue;
            materialBindingSource.DataSource = DBContext.Context.Material.ToList();

            product = productParam;

            productMaterialBindingSource.AddNew();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ((ProductMaterial)productMaterialBindingSource.Current).ProductID = product.ID;

                DBContext.Context.ProductMaterial.Add((ProductMaterial)productMaterialBindingSource.Current);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
