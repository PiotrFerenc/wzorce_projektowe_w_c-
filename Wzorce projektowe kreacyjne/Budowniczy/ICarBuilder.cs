using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy
{
    public interface ICarBuilder
    {
        ICar Car { set; get; }
        void SetName(string name);
        void SetSeats(int numberOfSeats);
        void SetEngine(Engine engine);
        void SetTripComputer(bool hasTripComputer);

        ICar Build();
    }
}