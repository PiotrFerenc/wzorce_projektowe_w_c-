using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy.CarBuilders
{
    public class ClassicCarBuilder : ICarBuilder
    {
        public ClassicCarBuilder()
        {
            Car = new ClassicCar();
        }

        public ICar Car { get; set; }


        public void SetName(string name)
        {
            Car.Name = name;
        }

        public void SetSeats(int numberOfSeats)
        {
            Car.Seats = numberOfSeats;
        }

        public void SetEngine(Engine engine)
        {
            Car.engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            Car.TripComputer = hasTripComputer;
        }

        public ICar Build()
        {
            return Car;
        }
    }
}