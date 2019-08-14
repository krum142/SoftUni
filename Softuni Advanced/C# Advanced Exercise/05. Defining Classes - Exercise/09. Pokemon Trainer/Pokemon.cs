using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name,string element,int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;

        }

        public string Name
        {
            get => this.name;
            private set => name = value;
        }
        public string Element
        {
            get => this.element;
            private set => element = value;
        }
        public int Health
        {
            get => this.health;
            private set => health = value;
        }
        public void ReduceHealth()
        {
            this.Health -= 10;
        }
    }
}
