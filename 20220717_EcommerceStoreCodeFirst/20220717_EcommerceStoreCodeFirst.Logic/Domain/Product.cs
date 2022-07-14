using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220717_EcommerceStoreCodeFirst.Logic
{
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public string StockQuantity { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Seller { get; set; }
        public string Image { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    }
}
