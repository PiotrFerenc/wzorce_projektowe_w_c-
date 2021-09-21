using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy
{
    public interface ICarBuilder
    {
        void SetName(string name);
        void SetSeats(int numberOfSeats);
        void SetEngine(Engine engine);
        void SetTripComputer(bool hasTripComputer);

 
    }
}