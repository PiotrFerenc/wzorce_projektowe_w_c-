using System;
using Budowniczy;
using Budowniczy.CarBuilders;
using Budowniczy.Cars;
using Fabryka;
using Fabryka_abstrakcyjna;
using Fabryka_abstrakcyjna.ControlFactory;
using Obserwator;
using Prototyp;
using Singleton;
using Strategia;
using Strategia.Strategies;

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
            
            Console.WriteLine("---Fabryka abstrakcyjna---");

            var windowsTextEditor = new TextEditor(new WindowsControlFactory());
            windowsTextEditor.Render();

            windowsTextEditor.ClickButton();
            
            var macTextEditor = new TextEditor(new MacControlFactory());
            macTextEditor.Render();
            
            macTextEditor.ClickButton();

            Console.WriteLine("---Koniec---");
            
            Console.WriteLine("---Prototyp---");

            var paper = new SheetOfPaper("Some text");

            var paper2 = paper.Clone();

            if (!ReferenceEquals(paper,paper2))
            {
                Console.WriteLine("Kopia bez referencji");
            }
            
            Console.WriteLine("---Koniec---");
            
            Console.WriteLine("---Singleton---");
            // var config = new GlobalConfiguration();
            
            var config = GlobalConfiguration.GetInstance(); 
            var cs = config.ConnectionString;
            Console.WriteLine(cs);

            Console.WriteLine("---Koniec---");
            
            Console.WriteLine("---Strategia---");

            var routeType = new BikeStrategy();
            var navigator = new Navigator(routeType);
            navigator.BuildRoute("Londyn","Paris");
            

            Console.WriteLine("---Koniec---");
            
            Console.WriteLine("---Obserwator---");

            var victim1 = new VictimSubscriber("127.0.0.1");
            var victim2 = new VictimSubscriber("127.0.0.2");

            var hacker = new HackerPublisher();
            hacker.ConnectToVictim(victim1);
            hacker.ConnectToVictim(victim2);
            
            hacker.RunAttack("DDOS");
            
            Console.WriteLine("---Koniec---");
            
        }
    }
}