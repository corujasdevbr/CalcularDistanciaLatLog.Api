using System.ComponentModel.DataAnnotations;

namespace CorujasDev.CalcularDistanciaLatLog.Api.DataTransferObject
{
    public class LocalRequestDTO
    {
        [Required(ErrorMessage = "Informe a latitude")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Informe a longitude")]
        public double Longitude { get; set; }
        public int Metros { get; set; } = 1000;
    }
}
