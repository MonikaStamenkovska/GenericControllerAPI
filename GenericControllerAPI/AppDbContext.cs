using GenericControllerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericControllerAPI
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
