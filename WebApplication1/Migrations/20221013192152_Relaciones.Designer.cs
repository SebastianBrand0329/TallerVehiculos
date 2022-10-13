﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerVehiculos.Data;

#nullable disable

namespace TallerVehiculos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221013192152_Relaciones")]
    partial class Relaciones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TallerVehiculos.Entidades.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("HistorialId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioReparacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioRespuestos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProcedimientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistorialId");

                    b.HasIndex("ProcedimientoId");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("KilometrajeIngreso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Historiales");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.ImagenVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("ImagenVehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.MarcaVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MarcaVehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Procedimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Procedimientos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TipoVehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cilindraje")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MarcaVehiculoId")
                        .HasColumnType("int");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaVehiculoId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Detalle", b =>
                {
                    b.HasOne("TallerVehiculos.Entidades.Historial", null)
                        .WithMany("Detalles")
                        .HasForeignKey("HistorialId");

                    b.HasOne("TallerVehiculos.Entidades.Procedimiento", null)
                        .WithMany("Detalles")
                        .HasForeignKey("ProcedimientoId");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Historial", b =>
                {
                    b.HasOne("TallerVehiculos.Entidades.Vehiculo", null)
                        .WithMany("Historials")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.ImagenVehiculo", b =>
                {
                    b.HasOne("TallerVehiculos.Entidades.Vehiculo", null)
                        .WithMany("ImagenVehiculos")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Vehiculo", b =>
                {
                    b.HasOne("TallerVehiculos.Entidades.MarcaVehiculo", null)
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaVehiculoId");

                    b.HasOne("TallerVehiculos.Entidades.TipoVehiculo", null)
                        .WithMany("Vehiculos")
                        .HasForeignKey("TipoVehiculoId");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Historial", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.MarcaVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Procedimiento", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("TallerVehiculos.Entidades.Vehiculo", b =>
                {
                    b.Navigation("Historials");

                    b.Navigation("ImagenVehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
