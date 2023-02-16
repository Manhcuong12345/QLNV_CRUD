using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore5CRUD.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //private readonly DbContextOptions _options;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //_options = options;
        }
  
        public DbSet<User> User { get; set; }
        public DbSet<Register> Register { get; set; }
    }
}