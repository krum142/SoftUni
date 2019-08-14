using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.numBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }
        public int NumBadges
        {
            get => this.numBadges;
            private set => this.numBadges = value;
        }
        public List<Pokemon> Pokemons
        {
            get => this.pokemons;
            private set => pokemons = value; 
        }
        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }
        public void IncreseBadges()
        {
            NumBadges++;
        }
        public void ReducePokemonHealth()
        {
            this.Pokemons.ForEach(p => p.ReduceHealth());
        }
        public void RemoveDead()
        {
            this.pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
        }


    }
}
