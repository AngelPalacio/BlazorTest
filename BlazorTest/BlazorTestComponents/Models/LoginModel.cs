using System.ComponentModel.DataAnnotations;
namespace BlazorTestComponents.Models
{
    public interface ILoginModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class LoginModel : ILoginModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "The user name must be at least 5 characters long")]
        public string Name { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "The password must be at least 5 characters long")]
        public string Password { get; set; }

    }
}
