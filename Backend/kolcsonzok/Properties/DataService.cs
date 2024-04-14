using Microsoft.EntityFrameworkCore;
using kolcsonzok; 

namespace kolcsonzok
{
    public class DataService : DbContext
    {
        public DataService(DbContextOptions<DataService> options)
            : base(options) {}

               public DbSet<Kolcsonzo> Kolcsonzesek { get; set; } = null!;
    }
}
