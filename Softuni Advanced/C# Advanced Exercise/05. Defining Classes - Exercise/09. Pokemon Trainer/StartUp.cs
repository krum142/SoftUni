using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Tournament")
                {
                    break;
                }

                string TrainerName = input[0];
                string PokemonName = input[1];
                string PokemonElement = input[2];
                int PokemonHealth = int.Parse(input[3]);


                if(!trainers.Any(x => x.Name == TrainerName))
                {
                    trainers.Add(new Trainer(TrainerName));

                }


                Trainer trainer = trainers.First(t => t.Name == TrainerName);

                trainer.Pokemons.Add(new Pokemon(PokemonName, PokemonElement, PokemonHealth));

            }

            while (true)
            {
                var checkElement = Console.ReadLine();
                if(checkElement == "End")
                {
                    break;
                }
                foreach (var trainer in trainers)
                {
                    if(trainer.Pokemons.Any(p => p.Element == checkElement))
                    {
                        trainer.IncreseBadges();
                    }
                    else
                    {
                        trainer.ReducePokemonHealth();
                        trainer.RemoveDead();
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
