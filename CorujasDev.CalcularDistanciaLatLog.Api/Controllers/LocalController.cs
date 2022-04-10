using CorujasDev.CalcularDistanciaLatLog.Api.DataTransferObject;
using CorujasDev.CalcularDistanciaLatLog.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace CorujasDev.CalcularDistanciaLatLog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalController : ControllerBase
    {
        private readonly ILocalRepositorio _localRepositorio;

        public LocalController(ILocalRepositorio localRepositorio)
        {
            _localRepositorio = localRepositorio;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] LocalRequestDTO request, CancellationToken cancelationToken) {

            var locais = _localRepositorio.ListarPorLatitudeLongitude(request.Latitude, request.Longitude, request.Metros);
            
            if (locais == null)
            {
                return await Task.FromResult(NotFound());
            }

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var currentLocation = geometryFactory.CreatePoint(new Coordinate(request.Latitude, request.Longitude));

            var locaisOrdenadosDistancia = locais
                        .ToList()
                        .Select(local => new LocalResponseDTO()
                        {
                            Id = local.Id,
                            Nome = local.Nome,
                            Endereco = local.Endereco,
                            Latitude = local.Latitude,
                            Longitude = local.Longitude,
                            Distancia = GreatCircleDistance(local.Longitude, local.Latitude,request.Longitude, request.Latitude)
                        })
                        .OrderBy(x => x.Distancia);

            return await Task.FromResult(Ok(locaisOrdenadosDistancia));
        }

        public static double Radians(double x)
        {
            return x * Math.PI / 180;
        }

        public static double GreatCircleDistance(double lon1, double lat1, double lon2, double lat2)
        {
            double R = 6371e3; // m

            double sLat1 = Math.Sin(Radians(lat1));
            double sLat2 = Math.Sin(Radians(lat2));
            double cLat1 = Math.Cos(Radians(lat1));
            double cLat2 = Math.Cos(Radians(lat2));
            double cLon = Math.Cos(Radians(lon1) - Radians(lon2));

            double cosD = sLat1 * sLat2 + cLat1 * cLat2 * cLon;

            double d = Math.Acos(cosD);

            double dist = R * d;

            return dist;
        }
    }
}
