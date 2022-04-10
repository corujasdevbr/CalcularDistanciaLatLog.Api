using CorujasDev.CalcularDistanciaLatLog.Api.Contextos;
using CorujasDev.CalcularDistanciaLatLog.Api.Dominios;
using CorujasDev.CalcularDistanciaLatLog.Api.Interfaces;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace CorujasDev.CalcularDistanciaLatLog.Api.Repositorios
{
    public class LocalRepositorio : ILocalRepositorio
    {
        protected new readonly DbLocalContext _context;

        public LocalRepositorio()
        {
            _context = new DbLocalContext();
        }

        public ICollection<Local> ListarPorLatitudeLongitude(double latitude, double longitude, int metros = 1000)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var myLocation = geometryFactory.CreatePoint(new Coordinate(latitude, longitude));

            var locais = _context.Locais.Where(x => x.LatLong != null);

            return locais.OrderBy(x => x.LatLong.Distance(myLocation))
                        .Where(x => x.LatLong.IsWithinDistance(myLocation, metros))
                        .ToList();
        }
    }
}
