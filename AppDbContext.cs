using Microsoft.EntityFrameworkCore;
using LifeMirror.Models;

namespace LifeMirror.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataEntry> DataEntries { get; set; }
    }
}
