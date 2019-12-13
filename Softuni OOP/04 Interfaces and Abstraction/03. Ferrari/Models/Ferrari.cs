using Ferraries.Interfaces;
using System;

namespace Ferraries.Models
{
    public class Ferrari : Car
    {
        private string model = "488-Spider";
        public Ferrari(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }  
        public string Brakes()
        {
            return $"Brakes!";
        }

        public string Gas()
        {
            return $"Gas!";
        }

        public override string ToString()
        {
            return $"{model}/{Brakes()}/{Gas()}/{Name}";
        }
    }
}
