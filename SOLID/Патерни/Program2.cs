using System;

namespace AdapterExample
{

    public interface ICoordinatesService
    {
        (double Latitude, double Longitude) GetCoordinates();
    }

 
    public class GeoLocation
    {
        public string GetCoordinates()
        {
            return "37.7749, -122.4194";
        }
    }

    public class GeoLocationAdapter : ICoordinatesService
    {
        private GeoLocation _geoLocation;

        public GeoLocationAdapter(GeoLocation geoLocation)
        {
            _geoLocation = geoLocation;
        }

        public (double Latitude, double Longitude) GetCoordinates()
        {
            string coordinates = _geoLocation.GetCoordinates();

            string[] parts = coordinates.Split(',');

            double latitude = double.Parse(parts[0]);
            double longitude = double.Parse(parts[1]);

            return (latitude, longitude);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            GeoLocation geoLocation = new GeoLocation();

            ICoordinatesService coordinatesService =
                new GeoLocationAdapter(geoLocation);

            var coordinates = coordinatesService.GetCoordinates();

            Console.WriteLine(
                $"Latitude: {coordinates.Latitude}, Longitude: {coordinates.Longitude}");
        }
    }
}