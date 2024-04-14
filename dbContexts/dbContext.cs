using DSR_KAZAR_N1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

public class dbContext : DbContext
{
    public DbSet<UporabnikModel> Uporabnik { get; set; }
    public DbSet<UporabnikZGesli> UporabnikZGesli { get; set; }
    public DbSet<Slika> Slika { get; set; }
    public DbSet<Racun> Racun { get; set; }

    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UporabnikModel>().ToTable("UporabnikModel");
        modelBuilder.Entity<UporabnikZGesli>()
            .HasOne(uzg => uzg.uporabnik)
            .WithMany()
            .HasForeignKey(uzg => uzg.UporabnikModelId);
        modelBuilder.Entity<Slika>().ToTable("Slika");
        modelBuilder.Entity<Racun>().ToTable("Racun");
    }
}