using System;

namespace Strategia.Strategies
{
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Walking from {start} to {end}");
        }
    }
}