using Microsoft.EntityFrameworkCore;

namespace ProductControl.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) { 
            
        }
    }
}
