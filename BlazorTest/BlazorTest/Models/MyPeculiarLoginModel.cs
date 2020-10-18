using BlazorTestComponents.Models;
using System.ComponentModel.DataAnnotations;
namespace BlazorTest.Models
{
    public class MyPeculiarLoginModel : ILoginModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "The user name must be at least 3 characters long")]
        public string Name { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The password must be at least 6 characters long")]
        public string Password { get; set; }
    }
}
