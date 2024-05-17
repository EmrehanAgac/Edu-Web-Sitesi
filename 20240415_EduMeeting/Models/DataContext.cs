using Microsoft.EntityFrameworkCore;

namespace _20240415_EduMeeting.Models
{
	public class DataContext:DbContext
	{
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Service> Service { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
