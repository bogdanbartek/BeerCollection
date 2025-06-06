using BeerCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BeerCollection.Models
{
    public class BeerContext : DbContext
    {
    
        public DbSet<Brewery> Breweries { get; set; }  
        public DbSet<Beer> Beers { get; set; } 
        public DbSet<Review> Reviews { get; set; }  

        public BeerContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlite(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Beer>()  
                .HasOne(b => b.Brewery)  
                .WithMany(br => br.Beers)  
                .HasForeignKey(b => b.BreweryId)  
                .OnDelete(DeleteBehavior.Restrict);  

          
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Beer)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BeerId)
                .OnDelete(DeleteBehavior.Cascade);  

           
            modelBuilder.Entity<Beer>()
                .Property(b => b.Price)
                .HasColumnType("decimal(6,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}