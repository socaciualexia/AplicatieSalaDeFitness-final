﻿// <auto-generated />
using System;
using AplicatieSalaDeFitness.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AplicatieSalaDeFitness.Migrations
{
    [DbContext(typeof(AplicatieSalaDeFitnessContext))]
    [Migration("20250111231630_UpdateNullableM")]
    partial class UpdateNullableM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Abonament", b =>
                {
                    b.Property<int>("AbonamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbonamentId"));

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbonamentId");

                    b.ToTable("Abonament");
                });

            modelBuilder.Entity("Antrenor", b =>
                {
                    b.Property<int>("AntrenorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AntrenorId"));

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specializare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AntrenorId");

                    b.ToTable("Antrenor");
                });

            modelBuilder.Entity("Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<int>("AntrenorId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeedbackId");

                    b.HasIndex("AntrenorId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Membru", b =>
                {
                    b.Property<int>("MembruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembruId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MembruId");

                    b.ToTable("Membru");
                });

            modelBuilder.Entity("Sesiune", b =>
                {
                    b.Property<int>("SesiuneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SesiuneId"));

                    b.Property<int>("AntrenorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SesiuneId");

                    b.HasIndex("AntrenorId");

                    b.ToTable("Sesiune");
                });

            modelBuilder.Entity("Feedback", b =>
                {
                    b.HasOne("Antrenor", "Antrenor")
                        .WithMany()
                        .HasForeignKey("AntrenorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Antrenor");
                });

            modelBuilder.Entity("Sesiune", b =>
                {
                    b.HasOne("Antrenor", "Antrenor")
                        .WithMany()
                        .HasForeignKey("AntrenorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Antrenor");
                });
#pragma warning restore 612, 618
        }
    }
}
