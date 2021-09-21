using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy.CarBuilders
{
    public class ClassicCarBuilder : ICarBuilder
    {
        private   ClassicCar _car;

        public ClassicCarBuilder()
        {
            _car = new ClassicCar();
        }

        public void SetName(string name)
        {
            _car.Name = name;
        }

        public void SetSeats(int numberOfSeats)
        {
            _car.Seats = numberOfSeats;
        }

        public void SetEngine(Engine engine)
        {
            _car.engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _car.TripComputer = hasTripComputer;
        }

        public ClassicCar GetCar()
        {
            var newClassicCar = _car;
            _car = new ClassicCar();
            
            return newClassicCar;
        }
    }
}