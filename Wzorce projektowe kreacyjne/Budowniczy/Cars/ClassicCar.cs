using Domain.Car;

namespace Budowniczy.Cars
{
    public class ClassicCar : ICar
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public Engine engine { get; set; }
        public bool TripComputer { get; set; }
        public CarDirector.CarType Type { get; set; }

        public ClassicCar()
        {
            Type = CarDirector.CarType.Classic;
        }
    }
}