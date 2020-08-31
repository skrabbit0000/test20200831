using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coreDB
{
    public partial class iiidbtestContext : DbContext
    {
        public iiidbtestContext()
        {
        }

        public iiidbtestContext(DbContextOptions<iiidbtestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCustomer> TCustomer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:iiidbtest01.database.windows.net,1433;Initial Catalog=iiidbtest;Persist Security Info=False;User ID=ken0526;Password=@Sktwo0526;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.ToTable("tCustomer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CName)
                    .HasColumnName("cName")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
