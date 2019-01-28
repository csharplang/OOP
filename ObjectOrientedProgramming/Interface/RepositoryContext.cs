using Microsoft.EntityFrameworkCore;

namespace OOP.Interface
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<PersonalInfo> PersonalInfo { get; set; }
    }
}
