using AuthServer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        // Stored Procedures or tables
        public DbSet<spGetOneExample> spGetOneExample { get; set; }
        public DbSet<spGetManyExamples> spGetManyExamples { get; set; }
    }
}
