﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.EntityFrameworkData;

namespace WebApplication1.EntityFrameworkData.Migrations
{
    [DbContext(typeof(AlmacenesDBContext))]
    [Migration("20191122162956_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("WebApplication1.Model.Almacen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacidad");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("IdDelegacion");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("IdDelegacion");

                    b.ToTable("Almacen");
                });

            modelBuilder.Entity("WebApplication1.Model.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("WebApplication1.Model.Delegacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Delegacion");
                });

            modelBuilder.Entity("WebApplication1.Model.Unidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("IdAlmacen");

                    b.Property<int>("IdArticulo");

                    b.Property<int>("Stock");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("IdAlmacen");

                    b.HasIndex("IdArticulo");

                    b.ToTable("Unidad");
                });

            modelBuilder.Entity("WebApplication1.Model.Almacen", b =>
                {
                    b.HasOne("WebApplication1.Model.Delegacion", "Delegacion")
                        .WithMany("Almacenes")
                        .HasForeignKey("IdDelegacion")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Model.Unidad", b =>
                {
                    b.HasOne("WebApplication1.Model.Almacen", "Almacen")
                        .WithMany("Unidades")
                        .HasForeignKey("IdAlmacen")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Model.Articulo", "Articulo")
                        .WithMany("Unidades")
                        .HasForeignKey("IdArticulo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
