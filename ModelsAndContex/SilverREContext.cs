using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverRealtrue.ModelsAndContex
{
    public partial class SilverREContext : DbContext
    {
        public SilverREContext()
        {
        }

        public SilverREContext(DbContextOptions<SilverREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Check> Check { get; set; }
        public virtual DbSet<DecimalNumber> DecimalNumber { get; set; }
        public virtual DbSet<SilverType> SilverType { get; set; }
        public virtual DbSet<Norm> Norm { get; set; }
        public virtual DbSet<Department> Department { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=ORIT-14\\SQLEXPRESS; Database=SilverRE; User ID=Student ORIT; Password=DabiduN");
                //"Server=DESKTOP-T9MJ8MA\\SQLEXPRESS; database=SilverRE; integrated Security=false; Trusted_Connection=True");
                //"Server=ORIT-14\\SQLEXPRESS; Database=SilverRE; User ID=Student ORIT; Password=DabiduN");
                //"DESKTOP-T9MJ8MA\\SQLEXPRESS; database=SilverRE; integrated Security=false; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Check>(entity =>
            {
                entity.HasKey(e => e.IdCheck);

                entity.Property(e => e.IdCheck).HasColumnName("ID_Check");

                entity.Property(e => e.AmountCheck).HasColumnName("Amount_Check");

                entity.Property(e => e.CoverageCheck)
                    .HasColumnName("Coverage_Check")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.DateCheck)
                    .HasColumnName("Date_Check")
                    .HasColumnType("datetime");

                entity.Property(e => e.DecimalCheck).HasColumnName("Decimal_Check");

                entity.Property(e => e.DepartmentCheck).HasColumnName("Department_Check");

                entity.Property(e => e.NormCheck)
                    .HasColumnName("Norm_Check")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.NumberCheck)
                    .HasColumnName("Number_Check")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderCheck)
                    .HasColumnName("Order_Check")
                    .HasMaxLength(10);

                entity.Property(e => e.SilverTypeCheck).HasColumnName("SilverType_Check");

                entity.HasOne(d => d.DepartmentCheckNavigation)
                    .WithMany(p => p.Check)
                    .HasForeignKey(d => d.DepartmentCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Check_Department");

                entity.HasOne(d => d.DecimalCheckNavigation)
                    .WithMany(p => p.Check)
                    .HasForeignKey(d => d.DecimalCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Check_Decimal");

                entity.HasOne(d => d.SilverTypeCheckNavigation)
                    .WithMany(p => p.Check)
                    .HasForeignKey(d => d.SilverTypeCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Check_SilverType");
            });

            modelBuilder.Entity<DecimalNumber>(entity =>
            {
                entity.HasKey(e => e.IdDecimal)
                    .HasName("PK_Norm");

                entity.Property(e => e.IdDecimal).HasColumnName("ID_Decimal");

                entity.Property(e => e.TitleDecimal)
                    .IsRequired()
                    .HasColumnName("Title_Decimal")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.CodeDepartment);

                entity.Property(e => e.CodeDepartment).HasColumnName("Code_Department");

                entity.Property(e => e.IsAtWorkDepartment)
                    .IsRequired()
                    .HasColumnName("IsAtWork_Department")
                    .HasColumnType("bit");
            });

            modelBuilder.Entity<SilverType>(entity =>
            {
                entity.HasKey(e => e.CodeSilverType);

                entity.Property(e => e.CodeSilverType).HasColumnName("Code_SilverType");

                entity.Property(e => e.TitleSilverType)
                    .IsRequired()
                    .HasColumnName("Title_SilverType")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Norm>(entity =>
            {
                entity.HasKey(e => e.IdNorm);

                entity.Property(e => e.IdNorm).HasColumnName("ID_Norm");

                entity.Property(e => e.TitleNorm)
                    .HasColumnName("Title_Norm")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.SilverTypeNorm)
                    .HasColumnName("SilverType_Norm");

                entity.Property(e => e.DecimalNorm)
                    .HasColumnName("Decimal_Norm");

                entity.Property(e => e.DepartmentNorm)
                    .HasColumnName("Department_Norm");

                entity.HasOne(d => d.DecimalNormNavigation)
                    .WithMany(p => p.Norm)
                    .HasForeignKey(d => d.DecimalNorm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Norm_Decimal");

                entity.HasOne(d => d.SilverTypeNormNavigation)
                    .WithMany(p => p.Norm)
                    .HasForeignKey(d => d.SilverTypeNorm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Norm_SilverType");

                entity.HasOne(d => d.DepartmentNormNavigation)
                    .WithMany(p => p.Norm)
                    .HasForeignKey(d => d.DepartmentNorm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Norm_Department");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
