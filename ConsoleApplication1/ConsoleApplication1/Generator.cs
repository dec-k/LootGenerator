using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    class Generator
    {
        private List<string> prefixes;
        private List<string> types;
        private List<string> suffixes;

        public List<Item> items;

        private Random r;
        private int maximumRarity;

        public Generator(List<string> prefixes, List<string> types, List<string> suffixes, int maximumRarity)
        {
            this.prefixes = prefixes;
            this.types = types;
            this.suffixes = suffixes;
            this.maximumRarity = maximumRarity;

            items = new List<Item>();

            r = new Random();
        }

        public void generateItems(int n)
        {
            //generate n number of random items based on the dictionaries this generator has
            for(int i = 0; i < n; i++)
            {
                items.Add(new Item(pickRandom(prefixes), pickRandom(types), pickRandom(suffixes), r, maximumRarity));
            }
        }

        public string pickRandom(List<string> list)
        {
            return list[r.Next(list.Count)];
        }

        public void outputItems()
        {
            for(int i = 0; i < items.Count; i++)
            {
                switch (items[i].rarity)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                }

                Console.WriteLine(items[i].displayText);
            }

            //After outputting, reset color.
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
