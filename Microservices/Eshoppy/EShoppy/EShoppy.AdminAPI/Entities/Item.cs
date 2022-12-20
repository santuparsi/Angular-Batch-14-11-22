using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShoppy.AdminAPI.Entities
{
    [Table("Item")]
    public class Item
    {
        [Key]
        
        public string ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
}
