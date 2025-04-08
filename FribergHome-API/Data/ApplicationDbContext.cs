using FribergHome_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHome_API.Data
{
    // Author: Christoffer
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<RealEstateAgency> Agencies {get;set;}
        public DbSet<RealEstateAgent> Agents { get; set; }
        public DbSet<Muncipality> Muncipalities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Property
            modelBuilder.Entity<Property>()
                .HasOne(p => p.Address)
                .WithMany(a => a.Properties)
                .HasForeignKey(p => p.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasOne(p => p.Muncipality)
                .WithMany(m => m.Properties)
                .HasForeignKey(p => p.MuncipalityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasOne(p => p.RealEstateAgent)
                .WithMany(a => a.Properties)
                .HasForeignKey(p => p.RealEstateAgentId)
                .OnDelete(DeleteBehavior.Restrict);

            // RealEstateAgent
            modelBuilder.Entity<RealEstateAgent>()
                .HasOne(a => a.Agency)
                .WithMany(agency => agency.Agents)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
    }
}
