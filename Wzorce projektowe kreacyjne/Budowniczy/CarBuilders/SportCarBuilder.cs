using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy.CarBuilders
{
    public class SportCarBuilder : ICarBuilder
    {
        private SportCar _car;

        public SportCarBuilder()
        {
            _car = new SportCar();
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
            _car.Engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _car.TripComputer = hasTripComputer;
        }

        public SportCar GetCar()
        {
            var newSportCar = _car;
            _car = new SportCar();

            return newSportCar;
        }
    }
}