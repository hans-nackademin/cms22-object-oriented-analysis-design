using Microsoft.EntityFrameworkCore;

namespace _05_DIP.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


    }
}
