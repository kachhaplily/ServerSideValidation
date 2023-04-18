using Microsoft.EntityFrameworkCore;
using ServerSideValidation.Model;

namespace ServerSideValidation.Data
{
    public class ValidationApiDbContext:DbContext
    {
        public ValidationApiDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Users> Users { get; set; }
    }
}
