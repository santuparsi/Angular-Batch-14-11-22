using System.ComponentModel.DataAnnotations;
namespace HandsMVCWithAPI.Models
{
    public class Product
    {

        [Required(ErrorMessage ="Pls Enter Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Pls Enter Price")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Pls Enter Stock")]
        public int? Stock { get; set; }
    }
}
