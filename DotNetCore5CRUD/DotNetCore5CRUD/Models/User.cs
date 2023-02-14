using System.ComponentModel.DataAnnotations;

namespace DotNetCore5CRUD.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string UserName { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Email { get; set; }

        [Required, MaxLength(2500)]
        public string Address { get; set; }

        public string PhoneNumber { get; set; }

       // [Required]
        public byte[] Poster { get; set; }

       
    }
}