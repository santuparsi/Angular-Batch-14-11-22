using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Pls Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Pls Enter Password")]
        public string Password { get; set; }
    }
}
