using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220717_EcommerceStoreCodeFirst.Logic
{
    public partial class Bill
    {
        public int Id { get; set; }
        public DateTime GenerationTime { get; set; }
        public bool IsPaid { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }
        public int OrderId { get; set; }

        [Required]
        public virtual Order Order { get; set; }
    }
}
