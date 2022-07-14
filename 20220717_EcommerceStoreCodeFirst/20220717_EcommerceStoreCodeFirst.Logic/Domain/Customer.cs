using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220717_EcommerceStoreCodeFirst.Logic
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Balance { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    }
}
