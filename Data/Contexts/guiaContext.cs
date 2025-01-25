using System;
using System.Collections.Generic;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public partial class guiaContext : DbContext
{
    public guiaContext()
    {
    }

    public guiaContext(DbContextOptions<guiaContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Excursion> Excursion { get; set; }
    public virtual DbSet<Guia> Guia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5755S3Q\\SQLEXPRESS;Database=Turismodbfirst;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Excursion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Excursio__3214EC073D9C235D");

            entity.ToTable("Excursion");

            entity.Property(e => e.GuideLanguage).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Guia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Guia__3214EC07D5976660");

            entity.ToTable("Guia");

            
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Years_of_Experience).HasMaxLength(50);

            entity.HasOne(d => d.Excursion).WithMany(p => p.Guia)
                .HasForeignKey(d => d.ExcursionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExcursionID");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}








