using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    class Program
    {
        public static List<string> prefixes;
        public static List<string> types;
        public static List<string> suffixes;

        static void Main(string[] args)
        {
            //Initialise the word lists
            prefixes = new List<string>();
            types = new List<string>();
            suffixes = new List<string>();

            //Populate the lists with data retrieved from txt files in .../bin/debug/
            fetchWordsFromFile(prefixes, "prefixes.txt");
            fetchWordsFromFile(types, "types.txt");
            fetchWordsFromFile(suffixes, "suffixes.txt");

            bool restarting = startCycle();

            while (restarting)
            {
                restarting = startCycle();
            }
        }

        private static void fetchWordsFromFile(List<string> list, string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                list.Add(line);
            }
        }

        public static bool startCycle()
        {
            //Ask for amount generated
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"How many items would you like to generate?\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your Answer: ");
            string input = Console.ReadLine();
            Console.Write("\n");

            //Ask for quality threshold
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Please enter the type of item's you would like to be generated?\"");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1) Only Broken items.");
            Console.WriteLine("2) Up to Normal quality.");
            Console.WriteLine("3) Up to Fine quality.");
            Console.WriteLine("4) Any Quality.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your Answer: ");
            string rareInput = Console.ReadLine();
            Console.Write("\n");

            //Setup generator
            Generator generator = new Generator(prefixes, types, suffixes, Convert.ToInt32(rareInput));

            //Generate Items & display them
            generator.generateItems(Convert.ToInt32(input));
            generator.outputItems();

            //Ask if repeat
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\"Would you like to generate some more?\" (y / n)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your Answer: ");
            string restartInput = Console.ReadLine();
            Console.Write("\n");

            if(restartInput == "y")
            {
                return true;
            }else
            {
                return false;
            }
        }

        
    }
}
