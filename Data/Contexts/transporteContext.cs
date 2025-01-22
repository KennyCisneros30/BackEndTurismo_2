﻿using System;
using System.Collections.Generic;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public partial class transporteContext : DbContext
{
    public transporteContext()
    {
    }

    public transporteContext(DbContextOptions<transporteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Transporte> Transportes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5755S3Q\\SQLEXPRESS;Database=Turismodbfirst;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transporte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transpor__3214EC07EA3B5F5E");

            entity.ToTable("Transporte");

            entity.Property(e => e.Capacity).HasMaxLength(100);
            entity.Property(e => e.Confort).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Brand).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
