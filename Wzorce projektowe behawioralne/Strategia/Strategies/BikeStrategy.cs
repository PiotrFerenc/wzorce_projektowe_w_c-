using System;

namespace Strategia.Strategies
{
    public class BikeStrategy : IRouteStrategy
    {
        public void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Bike from {start} to {end}");
        }
    }
}