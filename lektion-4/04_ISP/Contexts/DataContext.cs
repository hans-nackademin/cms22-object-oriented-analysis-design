using Microsoft.EntityFrameworkCore;

namespace _04_ISP.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
