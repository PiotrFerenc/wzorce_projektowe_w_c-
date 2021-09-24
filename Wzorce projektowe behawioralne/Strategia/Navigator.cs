using Strategia.Strategies;

namespace Strategia
{
    public class Navigator
    {
        private readonly IRouteStrategy _strategy;
        public Navigator(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void BuildRoute(string a, string b)
        {
            _strategy.BuildRoute(a,b);
        }
    }
}