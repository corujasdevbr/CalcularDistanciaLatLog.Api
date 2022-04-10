using GeoCoordinatePortable;

namespace CorujasDev.CalcularDistanciaLatLog.Api.DataTransferObject
{
    public class LocalResponseDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distancia { get; set; }
    }
}
