using System;

namespace Obserwator
{
    public class VictimSubscriber : IVictimSubscriber
    {
        private  string VictimIpAddress { set; get; }

        public VictimSubscriber(string victimIpAddress)
        {
            VictimIpAddress = victimIpAddress;
        }
        public void RunAttack(string attackType)
        {
            Console.WriteLine($"{attackType} on victim: {VictimIpAddress}");
        }
    }
}