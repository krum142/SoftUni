using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class Engine
    {
        private Dictionary<string, Dictionary<string, long>> bag;

        public Engine()
        {
            this.bag = new Dictionary<string, Dictionary<string, long>>();
        }

        public void Run()
        {
            long capacityOfBag = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine()
                ?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long gold = 0;
            long stones = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);

                string currentItem = string.Empty;

                FindCurrentItem(name, ref currentItem);

                if (currentItem == "")
                {
                    continue;
                }

                if (capacityOfBag < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (currentItem)
                {
                    case "Gem":
                        if (!bag.ContainsKey(currentItem))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (count > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[currentItem].Values.Sum() + count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(currentItem))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (count > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[currentItem].Values.Sum() + count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                AddNewItemInGroup(currentItem, name);

                bag[currentItem][name] += count;

                AddCountOfCurrentItem(currentItem, ref gold, count, ref stones, ref money);
            }

            PrintAllGroupsOfItemsInBag();
        }

        private void PrintAllGroupsOfItemsInBag()
        {
            foreach (var (groupOfItems, countOfItems) in bag)
            {
                Console.WriteLine($"<{groupOfItems}> ${countOfItems.Values.Sum()}");

                var sortedItems = countOfItems.OrderByDescending(y => y.Key).ThenBy(y => y.Value);

                foreach (var (currentItem, countOfItem) in sortedItems)
                {
                    Console.WriteLine($"##{currentItem} - {countOfItem}");
                }
            }
        }

        private static void AddCountOfCurrentItem(string currentItem, ref long gold, long count, ref long stones,
            ref long money)
        {
            if (currentItem == "Gold")
            {
                gold += count;
            }
            else if (currentItem == "Gem")
            {
                stones += count;
            }
            else if (currentItem == "Cash")
            {
                money += count;
            }
        }

        private void AddNewItemInGroup(string currentItem, string name)
        {
            if (!bag.ContainsKey(currentItem))
            {
                bag[currentItem] = new Dictionary<string, long>();
            }

            if (!bag[currentItem].ContainsKey(name))
            {
                bag[currentItem][name] = 0;
            }
        }

        private static void FindCurrentItem(string name, ref string currentItem)
        {
            if (name.Length == 3)
            {
                currentItem = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                currentItem = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                currentItem = "Gold";
            }
        }
    }
}