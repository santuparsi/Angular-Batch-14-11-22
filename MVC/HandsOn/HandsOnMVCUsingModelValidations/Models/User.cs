using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidations.Models
{
    public class User
    {


        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Range(18,34,ErrorMessage ="Age between 18 to 34")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage ="Invalid EmailId")]
        public string Email { get; set; }
        [RegularExpression("[6-9][0-9]{9}",ErrorMessage ="Invalid Mobile Format")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [RegularExpression("[a-z0-9]{6}", ErrorMessage = "Invalid Password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}
