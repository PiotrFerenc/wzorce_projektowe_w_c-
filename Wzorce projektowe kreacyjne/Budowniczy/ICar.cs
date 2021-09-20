using System.Runtime.InteropServices;
using Domain.Car;

namespace Budowniczy.Cars
{
    public interface ICar
    {
        string Name { set; get; }
        int Seats { set; get; }
        Engine engine { set; get; }
        bool TripComputer { set; get; }
        CarDirector.CarType Type { set; get; }
    }
}