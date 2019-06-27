using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name,Stat stat,Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }
        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }
        
        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }
        public int GetWeaponPower()
        {
            return Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
        }
        public int GetStatPower()
        {
            return Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Strength + Stat.Skills;
        }
        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();

            Sb.AppendLine($"[{this.Name}] - [{GetTotalPower()}]");
            Sb.AppendLine($"  Weapon Power: [{GetWeaponPower()}]");
            Sb.AppendLine($"  Stat Power: [{GetStatPower()}]");

            return Sb.ToString().TrimEnd(); // posible bug
        }
    }
}
