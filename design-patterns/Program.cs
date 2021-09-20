using System;
using Budowniczy;
using Budowniczy.CarBuilders;
using Budowniczy.Cars;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Budowniczy---");

            var sportCarBuilder = new SportCarBuilder();

            var director = new CarDirector(sportCarBuilder);
            var sportCar = director.Build();

            Console.WriteLine(sportCar.Name);
            Console.WriteLine(sportCar.Seats);
            Console.WriteLine(sportCar.TripComputer);
            
            Console.WriteLine("---Koniec---");


        }
    }
}