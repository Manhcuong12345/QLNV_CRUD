using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DotNetCore5CRUD.Models
{
    public class Register
    {
        
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //[Required]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }
    }
}
