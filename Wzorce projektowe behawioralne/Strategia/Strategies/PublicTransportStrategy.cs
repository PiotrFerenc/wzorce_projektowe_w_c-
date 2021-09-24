using System;

namespace Strategia.Strategies
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Public transport from {start} to {end}");
        }
    }
}