using Microsoft.EntityFrameworkCore;

namespace myWebApp.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        public DbSet<Model.Students>? Students { get; set; }
    }
}
