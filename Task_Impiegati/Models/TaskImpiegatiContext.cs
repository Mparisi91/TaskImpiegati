﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task_Impiegati.Models;

public partial class TaskImpiegatiContext : DbContext
{
    public TaskImpiegatiContext()
    {
    }

    public TaskImpiegatiContext(DbContextOptions<TaskImpiegatiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cittum> Citta { get; set; }

    public virtual DbSet<Impiegati> Impiegatis { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-12\\SQLEXPRESS;Database=Task_Impiegati;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cittum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Citta__3213E83FEBAF5CD3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomeCitta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_citta");
            entity.Property(e => e.ProvinciaRif).HasColumnName("provinciaRIF");

            entity.HasOne(d => d.ProvinciaRifNavigation).WithMany(p => p.Citta)
                .HasForeignKey(d => d.ProvinciaRif)
                .HasConstraintName("FK__Citta__provincia__412EB0B6");
        });

        modelBuilder.Entity<Impiegati>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impiegat__3213E83F58854620");

            entity.ToTable("Impiegati");

            entity.HasIndex(e => e.Matricola, "UQ__Impiegat__2C2751BA2996CA89").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Citta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("citta");
            entity.Property(e => e.Cognome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.DataNascita).HasColumnName("data_nascita");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Matricola)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("matricola");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Reparto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reparto");
            entity.Property(e => e.Ruolo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruolo");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Provinci__3213E83FBF4E44DB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomeProvincia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_provincia");
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reparto__3213E83F862A5E54");

            entity.ToTable("Reparto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomeReparto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_reparto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
