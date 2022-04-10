using CorujasDev.CalcularDistanciaLatLog.Api.Dominios;

namespace CorujasDev.CalcularDistanciaLatLog.Api.Interfaces
{
    public interface ILocalRepositorio
    {
        /// <summary>
        /// Lista os locais mais próximos de um determinado local
        /// </summary>
        /// <param name="latitude">Latitude do local que deseja se basear</param>
        /// <param name="longitude">Longitude do local que deseja se basear</param>
        /// <param name="km">Raio de distancia que deseja buscar os locais mais próximos</param>
        /// <returns></returns>
        public ICollection<Local> ListarPorLatitudeLongitude(double latitude, double longitude, int metros = 1000);
    }
}
