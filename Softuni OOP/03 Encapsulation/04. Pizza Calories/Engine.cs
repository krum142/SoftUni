using System;

namespace PizzaCalories
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                var tokens = Console.ReadLine()?.Split();

                if (tokens != null)
                {
                    Pizza pizza = new Pizza(tokens[1]);

                    tokens = Console.ReadLine()?.Split();

                    if (tokens != null)
                    {
                        pizza.Dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));

                        string command;

                        while ((command = Console.ReadLine()) != "END")
                        {
                            if (command != null)
                            {
                                tokens = command.Split();
                            }

                            pizza.AddTopping(new Topping(tokens[1], int.Parse(tokens[2])));
                        }
                    }

                    Console.WriteLine(pizza);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}