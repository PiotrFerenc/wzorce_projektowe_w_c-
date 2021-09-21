using System;
using Budowniczy.Cars;
using Domain.Car;

namespace Budowniczy
{
    public class CarDirector
    {
        private readonly ICarBuilder _builder;
        
        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSportCar()
        {
            _builder.SetEngine(new Engine("Some sport engine",5.0));
            _builder.SetName("Very fast car");
            _builder.SetSeats(2);
            _builder.SetTripComputer(false);
        }
        
        public void BuildClasssicCar()
        {
            _builder.SetEngine(new Engine("Some classic engine",1.0));
            _builder.SetName("Very classic car");
            _builder.SetSeats(4);
            _builder.SetTripComputer(true);
        }


        public enum CarType
        {
            Sport,
            Classic
        }
    }

  
}