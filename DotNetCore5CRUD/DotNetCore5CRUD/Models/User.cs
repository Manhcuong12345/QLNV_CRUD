using System.ComponentModel.DataAnnotations;

namespace DotNetCore5CRUD.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string UserName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }

        [Required, MaxLength(2500)]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public byte[] Poster { get; set; }

       
    }
}