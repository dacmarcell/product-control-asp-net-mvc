using Microsoft.EntityFrameworkCore;
using ProductControl.Models;

namespace ProductControl.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        }

        public DbSet<ProductModel> Product { get; set; }
    }
}
