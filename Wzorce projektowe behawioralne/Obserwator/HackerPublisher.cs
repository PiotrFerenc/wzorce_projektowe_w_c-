using System.Collections.Generic;

namespace Obserwator
{
    public class HackerPublisher
    {
        private List<IVictimSubscriber> _victims = new List<IVictimSubscriber>();

        public void ConnectToVictim(IVictimSubscriber victimSubscriber)
        {
            _victims.Add(victimSubscriber);
        }

        public void RunAttack(string attackName)
        {
            foreach (var victim in _victims)
            {
                victim.RunAttack(attackName);
            }
        }
    }
}