using LopushokApp.Models;
using LopushokApp.Utilities;
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
        public MainForm()
        {
            InitializeComponent();

            products = DBContext.Context.Product.ToList();

            GenerateProductCards(products);
        }

        private void GenerateProductCards(List<Product> products)
        {
            foreach (Product product in products)
            {
                ProductCard card = new ProductCard();
                card.GenerateProductData(product);
                flowLayoutPanel.Controls.Add(card);
            }
        }
    }
}
