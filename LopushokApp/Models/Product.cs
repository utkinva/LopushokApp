namespace LopushokApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductCostHistory = new HashSet<ProductCostHistory>();
            ProductMaterial = new HashSet<ProductMaterial>();
            ProductSale = new HashSet<ProductSale>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int? ProductTypeID { get; set; }

        [Required]
        [StringLength(10)]
        public string ArticleNumber { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? ProductionPersonCount { get; set; }

        public int? ProductionWorkshopNumber { get; set; }

        public decimal MinCostForAgent { get; set; }
        public decimal Cost
        {
            get
            {
                decimal cost = 0;

                foreach (var material in ProductMaterial)
                {
                    if (material.ProductID == ID)
                    {
                        cost += (decimal.Parse(material.Count.ToString()) * material.Material.Cost);
                    }
                }

                return cost;
            }
        }

        public decimal Sales
        {
            get
            {
                decimal salesSum = 0;

                foreach (ProductSale sale in ProductSale)
                {
                    if (sale.ProductID == ID
                        && sale.SaleDate.Month == DateTime.Now.Month
                        && sale.SaleDate.Year == DateTime.Now.Year)
                    {
                        salesSum += sale.ProductCount * sale.Product.MinCostForAgent;
                    }
                }

                return salesSum;
            }
        }


        public virtual ProductType ProductType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCostHistory> ProductCostHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
