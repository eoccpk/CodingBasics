using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220717_EcommerceStoreCodeFirst.Logic
{
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public System.DateTime OrderTime { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDispatched { get; set; }
        public Nullable<System.DateTime> DispatchTime { get; set; }
        public bool IsDelivered { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Order()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    
    }
}
