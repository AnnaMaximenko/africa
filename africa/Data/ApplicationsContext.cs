using Microsoft.EntityFrameworkCore;

namespace africa.Data
{
    public class ApplicationsContext : DbContext
    {
        public ApplicationsContext(DbContextOptions<ApplicationsContext> options)
        : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
