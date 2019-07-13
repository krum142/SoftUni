using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingSpree.Models;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> persons;
        private List<Product> products;
        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPersonsInput();
                ReadProductsInput();

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] commandTokens = command
                        .Split(" ",
                            StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = this.persons
                        .FirstOrDefault(p => p.Name == personName);

                    Product product = this.products
                        .FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);

                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                command = Console.ReadLine();

            }


            Console.WriteLine(String.Join(Environment.NewLine, this.persons));
            
        }

        private void ReadProductsInput()
        {
            var productsInput = Console.ReadLine()
                .Split(";",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var pt in productsInput)
            {
                var productInfo = pt
                    .Split("=")
                    .ToArray();

                var name = productInfo[0];
                var cost = decimal.Parse(productInfo[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void ReadPersonsInput()
        {
            var personTokens = Console.ReadLine()
                .Split(";",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var pt in personTokens)
            {
                var personInfo = pt
                    .Split("=")
                    .ToArray();

                var name = personInfo[0];
                var money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                this.persons.Add(person);
            }
        }
    }
}
