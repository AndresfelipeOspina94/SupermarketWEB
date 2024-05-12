using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class AutentiContext : DbContext
    {
        public AutentiContext(DbContextOptions<AutentiContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } 
    }
}
