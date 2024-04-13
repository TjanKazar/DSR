using DSR_KAZAR_N1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

public class dbContext : DbContext
{
    public DbSet<UporabnikModel> Uporabnik { get; set; }
    public DbSet<UporabnikZGesli> UporabnikZGesli { get; set; }
    public DbSet<Slika> Slika { get; set; }
    public DbSet<Racun> Racun { get; set; }


    public string DbPath { get; }

    public dbContext()
    {
        var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        DbPath = Path.Combine(projectDirectory, "uporabnik.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}