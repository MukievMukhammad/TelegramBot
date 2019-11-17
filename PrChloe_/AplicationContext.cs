using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using PrChloe_.Models.Components;

namespace PrChloe_
{
    public sealed class ApplicationContext : DbContext
    {
        public static readonly ILoggerFactory LoggerFactory = 
            new LoggerFactory(new[] {
            new ConsoleLoggerProvider((category, level) =>
                category == DbLoggerCategory.Database.Command.Name &&
                level == LogLevel.Information, true)
        });
        
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}