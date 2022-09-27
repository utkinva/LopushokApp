using LopushokApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokApp.View.PartialView
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void GenerateProductData(Product product)
        {
            titleTypeLabel.Text = $"{product.ProductType.Title} | {product.Title}";
            articleLabel.Text = product.ArticleNumber;
            costLabel.Text = $"{product.Cost} руб.";
            logoPictureBox.ImageLocation = product.Image;
            idLabel.Text = product.ID.ToString();

            string materials = "Материалы: ";

            foreach (ProductMaterial material in product.ProductMaterial)
            {
                materials += $" {material.Material.Title}, ";
            }

            materialsLabel.Text = materials.Substring(0, materials.Length - 2);

            if (product.Sales <= 0)
                titleTypeLabel.BackColor = Color.FromArgb(255, 114, 118);
        }
    }
}
