using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Format For Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{6,}$", ErrorMessage = "Password does not meet complexity requirements.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
