using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoneyMeExam.Models
{
    public partial class sampleContext : DbContext
    {
        public sampleContext()
        {
        }

        public sampleContext(DbContextOptions<sampleContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=moneymedb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBlacklistedDomain>(entity =>
            {
                entity.ToTable("tblBlacklistedDomain");

                entity.Property(e => e.BlacklistedDomainId).ValueGeneratedOnAdd();

                entity.Property(e => e.Domain)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBlacklistedMobile>(entity =>
            {
                entity.ToTable("tblBlacklistedMobile");

                entity.Property(e => e.BlacklistedMobileId).ValueGeneratedOnAdd();

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
