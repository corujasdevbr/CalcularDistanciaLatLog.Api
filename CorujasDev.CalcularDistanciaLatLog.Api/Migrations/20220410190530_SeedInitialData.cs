using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace CorujasDev.CalcularDistanciaLatLog.Api.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locais",
                columns: new[] { "Id", "Endereco", "LatLong", "Latitude", "Longitude", "Nome" },
                values: new object[,]
                {
                    { new Guid("21a061db-c9b2-4257-a092-01aa4fcf4584"), "R. Azevedo Soares, 2042 - Tatuape, São Paulo - SP, 03322-002", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5471431 -46.5593086)"), -23.5471431, -46.559308600000001, "Pró3 Academia - Vila Carrão" },
                    { new Guid("26dfaf4f-cd88-4312-9299-db3b96c33b6c"), "R. Tuiuti, 1807 - Tatuapé, São Paulo - SP, 03307-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5413278 -46.5774019)"), -23.541327800000001, -46.577401899999998, "Casa do Pastel Tatuapé" },
                    { new Guid("616845fc-3022-41c9-bdcd-a8ac6056ba76"), "R. Antônio de Barros, 285 - Tatuapé, São Paulo - SP, 03089-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5328637 -46.5618107)"), -23.5328637, -46.561810700000002, "Kanguru Supermercado" },
                    { new Guid("72397a9a-6a5f-4de3-a1f7-3345ff4a6ce6"), "R. São Jorge, 168 - Parque São Jorge, São Paulo - SP, 03087-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5319057 -46.5669481)"), -23.531905699999999, -46.566948099999998, "Lopes Supermercados" },
                    { new Guid("abd81ad5-df34-4343-9528-93ebd12e0cad"), "R. Antônio de Barros, 213 - Tatuapé, São Paulo - SP, 03089-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5322009 -46.5620454)"), -23.532200899999999, -46.562045400000002, "Cacau Show" },
                    { new Guid("ecfc0b6b-7cb2-4761-9390-b716d13586d7"), "R. Antônio de Barros, 203 - Tatuapé, São Paulo - SP, 03089-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5321539 -46.5621212)"), -23.532153900000001, -46.5621212, "O Boticário" },
                    { new Guid("edb19deb-db32-4b16-91fd-5bb6d6db0d76"), "Av. Celso Garcia, 5836 - Tatuapé, São Paulo - SP, 03064-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5307344 -46.5588578)"), -23.5307344, -46.558857799999998, "Hotel Luar" },
                    { new Guid("edba3333-c428-48f2-8182-dd368fa7878a"), "R. Bom Sucesso, 510 - Cidade Mãe do Céu, São Paulo - SP, 03305-000", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-23.5450925 -46.5787504)"), -23.545092499999999, -46.578750399999997, "Hotel Flert Tatuapé" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("21a061db-c9b2-4257-a092-01aa4fcf4584"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("26dfaf4f-cd88-4312-9299-db3b96c33b6c"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("616845fc-3022-41c9-bdcd-a8ac6056ba76"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("72397a9a-6a5f-4de3-a1f7-3345ff4a6ce6"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("abd81ad5-df34-4343-9528-93ebd12e0cad"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("ecfc0b6b-7cb2-4761-9390-b716d13586d7"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("edb19deb-db32-4b16-91fd-5bb6d6db0d76"));

            migrationBuilder.DeleteData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("edba3333-c428-48f2-8182-dd368fa7878a"));
        }
    }
}
