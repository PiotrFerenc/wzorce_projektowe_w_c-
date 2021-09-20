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

        public ICar Build()
        {
            switch (_builder.Car.Type)
            {
                case CarType.Sport:
                    _builder.SetEngine(new Engine("Some sport engine",5.0));
                    _builder.SetName("Very fast car");
                    _builder.SetSeats(2);
                    _builder.SetTripComputer(false);
                    break;
                case CarType.Classic:
                    _builder.SetEngine(new Engine("Some classic engine",1.0));
                    _builder.SetName("Very classic car");
                    _builder.SetSeats(4);
                    _builder.SetTripComputer(true);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_builder.Car.Type), _builder.Car.Type, null);
            }

            return _builder.Build();
        }

        public enum CarType
        {
            Sport,
            Classic
        }
    }

  
}