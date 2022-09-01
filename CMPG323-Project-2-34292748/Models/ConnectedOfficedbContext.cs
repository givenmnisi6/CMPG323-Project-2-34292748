using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CMPG323_Project_2_34292748.Models
{
    public partial class ConnectedOfficedbContext : DbContext
    {
        public ConnectedOfficedbContext()
        {
        }

        public ConnectedOfficedbContext(DbContextOptions<ConnectedOfficedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:cmpg323sql.database.windows.net,1433;Initial Catalog=ConnectedOfficedb;Persist Security Info=False;User ID=givenmnisi6;Password=GM-0108095163086;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZoneID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ZoneName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
