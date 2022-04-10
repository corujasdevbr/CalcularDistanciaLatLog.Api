﻿// <auto-generated />
using System;
using CorujasDev.CalcularDistanciaLatLog.Api.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace CorujasDev.CalcularDistanciaLatLog.Api.Migrations
{
    [DbContext(typeof(DbLocalContext))]
    partial class DbLocalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CorujasDev.CalcularDistanciaLatLog.Api.Dominios.Local", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Point>("LatLong")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locais");

                    b.HasData(
                        new
                        {
                            Id = new Guid("edb19deb-db32-4b16-91fd-5bb6d6db0d76"),
                            Endereco = "Av. Celso Garcia, 5836 - Tatuapé, São Paulo - SP, 03064-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5307344 -46.5588578)"),
                            Latitude = -23.5307344,
                            Longitude = -46.558857799999998,
                            Nome = "Hotel Luar"
                        },
                        new
                        {
                            Id = new Guid("ecfc0b6b-7cb2-4761-9390-b716d13586d7"),
                            Endereco = "R. Antônio de Barros, 203 - Tatuapé, São Paulo - SP, 03089-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5321539 -46.5621212)"),
                            Latitude = -23.532153900000001,
                            Longitude = -46.5621212,
                            Nome = "O Boticário"
                        },
                        new
                        {
                            Id = new Guid("616845fc-3022-41c9-bdcd-a8ac6056ba76"),
                            Endereco = "R. Antônio de Barros, 285 - Tatuapé, São Paulo - SP, 03089-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5328637 -46.5618107)"),
                            Latitude = -23.5328637,
                            Longitude = -46.561810700000002,
                            Nome = "Kanguru Supermercado"
                        },
                        new
                        {
                            Id = new Guid("abd81ad5-df34-4343-9528-93ebd12e0cad"),
                            Endereco = "R. Antônio de Barros, 213 - Tatuapé, São Paulo - SP, 03089-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5322009 -46.5620454)"),
                            Latitude = -23.532200899999999,
                            Longitude = -46.562045400000002,
                            Nome = "Cacau Show"
                        },
                        new
                        {
                            Id = new Guid("72397a9a-6a5f-4de3-a1f7-3345ff4a6ce6"),
                            Endereco = "R. São Jorge, 168 - Parque São Jorge, São Paulo - SP, 03087-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5319057 -46.5669481)"),
                            Latitude = -23.531905699999999,
                            Longitude = -46.566948099999998,
                            Nome = "Lopes Supermercados"
                        },
                        new
                        {
                            Id = new Guid("26dfaf4f-cd88-4312-9299-db3b96c33b6c"),
                            Endereco = "R. Tuiuti, 1807 - Tatuapé, São Paulo - SP, 03307-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5413278 -46.5774019)"),
                            Latitude = -23.541327800000001,
                            Longitude = -46.577401899999998,
                            Nome = "Casa do Pastel Tatuapé"
                        },
                        new
                        {
                            Id = new Guid("21a061db-c9b2-4257-a092-01aa4fcf4584"),
                            Endereco = "R. Azevedo Soares, 2042 - Tatuape, São Paulo - SP, 03322-002",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5471431 -46.5593086)"),
                            Latitude = -23.5471431,
                            Longitude = -46.559308600000001,
                            Nome = "Pró3 Academia - Vila Carrão"
                        },
                        new
                        {
                            Id = new Guid("edba3333-c428-48f2-8182-dd368fa7878a"),
                            Endereco = "R. Bom Sucesso, 510 - Cidade Mãe do Céu, São Paulo - SP, 03305-000",
                            LatLong = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5450925 -46.5787504)"),
                            Latitude = -23.545092499999999,
                            Longitude = -46.578750399999997,
                            Nome = "Hotel Flert Tatuapé"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}