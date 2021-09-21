using System;
using Budowniczy;
using Budowniczy.CarBuilders;
using Budowniczy.Cars;
using Fabryka;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Budowniczy---");

            var sportCarBuilder = new SportCarBuilder();

            var director = new CarDirector(sportCarBuilder);
            director.BuildSportCar();

            var sportCar = sportCarBuilder.GetCar();

            Console.WriteLine(sportCar.Name);
            Console.WriteLine(sportCar.Seats);
            Console.WriteLine(sportCar.Engine.EngineCapacity);

            Console.WriteLine("---Koniec---");

            Console.WriteLine("---Fabryka---");

            var emojiFactory = new EmojiFactory();
            var happyEmoji = emojiFactory.CreateEmoji(EmojiType.Happy);

            happyEmoji.Render();

            Console.WriteLine("---Koniec---");
        }
    }
}