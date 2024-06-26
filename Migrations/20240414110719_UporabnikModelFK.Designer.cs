﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DSR_KAZAR_N1.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240414110719_UporabnikModelFK")]
    partial class UporabnikModelFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("DSR_KAZAR_N1.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("cenaSkupaj")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("datumIzdaje")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Racun", (string)null);
                });

            modelBuilder.Entity("DSR_KAZAR_N1.Models.Slika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("cena")
                        .HasColumnType("REAL");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("jeUnikat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("letoIzdaje")
                        .HasColumnType("INTEGER");

                    b.Property<int>("racunId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("racunId");

                    b.ToTable("Slika", (string)null);
                });

            modelBuilder.Entity("DSR_KAZAR_N1.Models.UporabnikZGesli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UporabnikModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UporabnikModelId");

                    b.ToTable("UporabnikZGesli");
                });

            modelBuilder.Entity("UporabnikModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("birthplace")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("emso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("post")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("postnum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UporabnikModel", (string)null);
                });

            modelBuilder.Entity("DSR_KAZAR_N1.Models.Slika", b =>
                {
                    b.HasOne("DSR_KAZAR_N1.Models.Racun", "racun")
                        .WithMany()
                        .HasForeignKey("racunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("racun");
                });

            modelBuilder.Entity("DSR_KAZAR_N1.Models.UporabnikZGesli", b =>
                {
                    b.HasOne("UporabnikModel", "uporabnik")
                        .WithMany()
                        .HasForeignKey("UporabnikModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("uporabnik");
                });
#pragma warning restore 612, 618
        }
    }
}
