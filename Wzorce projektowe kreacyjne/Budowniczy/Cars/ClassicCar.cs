using Domain.Car;

namespace Budowniczy.Cars
{
    public class ClassicCar 
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public Engine engine { get; set; }
        public bool TripComputer { get; set; }
        public CarDirector.CarType Type { get; set; }

    }
}