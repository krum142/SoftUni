using System.Collections.Generic;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;
        public Arena(string name)
        {
            this.Name = name;
            gladiators = new List<Gladiator>();
        }
        public string Name { get; set; }

        public int Count => gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            var gladiatorToRemove = gladiators.FirstOrDefault(g => g.Name == name);

            gladiators.Remove(gladiatorToRemove);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            var gladiator = gladiators.OrderByDescending(g => g.GetStatPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            var gladiator = gladiators.OrderByDescending(g => g.GetWeaponPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            var gladiator = gladiators.OrderByDescending(g => g.GetTotalPower()).FirstOrDefault();

            return gladiator;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
