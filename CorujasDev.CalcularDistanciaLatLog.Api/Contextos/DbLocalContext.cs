using CorujasDev.CalcularDistanciaLatLog.Api.Dominios;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace CorujasDev.CalcularDistanciaLatLog.Api.Contextos
{
    public class DbLocalContext : DbContext
    {
        public DbLocalContext()
        {

        }

        public DbLocalContext(DbContextOptions<DbLocalContext> options) : base(options)
        {

        }

        public DbSet<Local> Locais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Local_Dev;Integrated Security=True",
                    x => x.UseNetTopologySuite()
                );
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Local>().HasData(
                new Local { Id = Guid.NewGuid(), Nome = "Hotel Luar", Endereco = "Av. Celso Garcia, 5836 - Tatuapé, São Paulo - SP, 03064-000", Latitude = -23.5307344, Longitude = -46.5588578, LatLong = new Point(-23.5307344, -46.5588578) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "O Boticário", Endereco = "R. Antônio de Barros, 203 - Tatuapé, São Paulo - SP, 03089-000", Latitude = -23.5321539, Longitude = -46.5621212, LatLong = new Point(-23.5321539, -46.5621212) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Kanguru Supermercado", Endereco = "R. Antônio de Barros, 285 - Tatuapé, São Paulo - SP, 03089-000", Latitude = -23.5328637, Longitude = -46.5618107, LatLong = new Point(-23.5328637, -46.5618107) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Cacau Show", Endereco = "R. Antônio de Barros, 213 - Tatuapé, São Paulo - SP, 03089-000", Latitude = -23.5322009, Longitude = -46.5620454, LatLong = new Point(-23.5322009, -46.5620454) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Lopes Supermercados", Endereco = "R. São Jorge, 168 - Parque São Jorge, São Paulo - SP, 03087-000", Latitude = -23.5319057, Longitude = -46.5669481, LatLong = new Point(-23.5319057, -46.5669481) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Casa do Pastel Tatuapé", Endereco = "R. Tuiuti, 1807 - Tatuapé, São Paulo - SP, 03307-000", Latitude = -23.5413278, Longitude = -46.5774019, LatLong = new Point(-23.5413278, -46.5774019) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Pró3 Academia - Vila Carrão", Endereco = "R. Azevedo Soares, 2042 - Tatuape, São Paulo - SP, 03322-002", Latitude = -23.5471431, Longitude = -46.5593086, LatLong = new Point(-23.5471431, -46.5593086) { SRID = 4326 } },
                new Local { Id = Guid.NewGuid(), Nome = "Hotel Flert Tatuapé", Endereco = "R. Bom Sucesso, 510 - Cidade Mãe do Céu, São Paulo - SP, 03305-000", Latitude = -23.5450925, Longitude = -46.5787504, LatLong = new Point(-23.5450925, -46.5787504) { SRID = 4326 } }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
