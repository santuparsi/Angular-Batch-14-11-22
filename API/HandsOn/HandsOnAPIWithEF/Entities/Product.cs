using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIWithEF.Entities
{
    public class Product
    {
        [Key] //primary key and identity will applied
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
