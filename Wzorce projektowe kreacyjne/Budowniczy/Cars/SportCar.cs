using Domain.Car;

namespace Budowniczy.Cars
{
    public class SportCar 
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public bool TripComputer { get; set; }
        public CarDirector.CarType Type { get; set; }

    }
}