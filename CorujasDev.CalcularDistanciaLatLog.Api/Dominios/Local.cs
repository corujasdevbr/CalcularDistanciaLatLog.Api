using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorujasDev.CalcularDistanciaLatLog.Api.Dominios
{
    [Table("Locais")]
    public class Local
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Point LatLong { get; set; }
    }
}
