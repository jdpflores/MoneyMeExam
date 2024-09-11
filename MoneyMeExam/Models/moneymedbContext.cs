using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoneyMeExam.Models
{
    public partial class moneymedbContext : DbContext
    {
        public moneymedbContext()
        {
        }

        public moneymedbContext(DbContextOptions<moneymedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLoan> TblLoans { get; set; } = null!;
        public virtual DbSet<TblQoute> TblQoutes { get; set; } = null!;
        public virtual DbSet<TblBlacklistedDomain> TblBlacklistedDomains { get; set; } = null!;
        public virtual DbSet<TblBlacklistedMobile> TblBlacklistedMobiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=moneymedb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLoan>(entity =>
            {
                entity.ToTable("tblLoan");

                entity.Property(e => e.EstablishmentFee).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.FinanceAmount).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.InterestAmount).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.InterestPerc).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.LoanId).ValueGeneratedOnAdd();

                entity.Property(e => e.NoOfWeeks).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.TotalRepayment).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.WeeklyRepayment).HasColumnType("decimal(18, 7)");
            });

            modelBuilder.Entity<TblQoute>(entity =>
            {
                entity.ToTable("tblQoute");

                entity.Property(e => e.QouteId).ValueGeneratedOnAdd();

                entity.Property(e => e.AmountRquired).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

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
