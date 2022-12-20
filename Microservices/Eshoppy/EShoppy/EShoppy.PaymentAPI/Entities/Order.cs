using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShoppy.PaymentAPI.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        [ForeignKey("Item")]
        [Required]
        public string ItemId { get; set; }
        public DateTime OrderDate { get; set; }
        public Item Item { get; set; }
    }
}
