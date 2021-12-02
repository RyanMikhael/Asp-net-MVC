using Microsoft.EntityFrameworkCore;

namespace projeto_final.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options){}

        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}