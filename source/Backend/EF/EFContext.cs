using Backend.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Backend.EF
{
    public class EFContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public EFContext(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=TestLoadTelerik;Trusted_Connection=True;";

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connection);
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasKey(p => p.NAM);
        }

        public DbSet<Person> Persons { get; set; }
    }
}
