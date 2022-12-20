using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShoppy.AccountAPI.Entities
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public string PaymentId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Item")]
        public string ItemId { get; set; }
        public double Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }
    }
}

