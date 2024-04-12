
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using A11_IC_CreateContextLibary.Models;


namespace A11_IC_CreateContextLibary.Context
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(
                configuration.GetConnectionString("MovieContext")
            );
        }
    }
}
