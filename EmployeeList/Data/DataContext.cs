using Microsoft.EntityFrameworkCore;

namespace EmployeeList.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeePersonality> EmployeePersonalities => Set<EmployeePersonality>();
    }
}
