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
            prefixes = new List<string>();
            prefixes.Add("Rotten");
            prefixes.Add("Infested");
            prefixes.Add("Diseased");
            prefixes.Add("Blazing");
            prefixes.Add("Fiery");
            prefixes.Add("Demonic");
            prefixes.Add("Hellish");
            prefixes.Add("Diabolic");
            prefixes.Add("Divine");
            prefixes.Add("Pure");
            prefixes.Add("Ascended");
            prefixes.Add("Martyr's");
            prefixes.Add("Savant's");
            prefixes.Add("Nihilist's");
            prefixes.Add("Savage");
            prefixes.Add("Brutal");
            prefixes.Add("Vicious");
            prefixes.Add("Extreme");
            prefixes.Add("Fine");
            prefixes.Add("Exceptional");
            prefixes.Add("Masterworked");
            prefixes.Add("Honed");
            prefixes.Add("Precise");
            prefixes.Add("Rampaging");
            prefixes.Add("Chaotic");
            prefixes.Add("Nightmarish");
            prefixes.Add("Ghoulish");
            prefixes.Add("Hardened");
            prefixes.Add("Attuned");
            prefixes.Add("Balanced");
            prefixes.Add("Heavy");
            prefixes.Add("Light-Weight");
            prefixes.Add("Profane");
            prefixes.Add("Enigmatic");
            prefixes.Add("Blighted");
            prefixes.Add("Mysterious");
            prefixes.Add("Sacred");
            prefixes.Add("Eclipsing");
            prefixes.Add("Dark");
            prefixes.Add("Perfect");
            prefixes.Add("Flawed");
            prefixes.Add("Broken");
            prefixes.Add("Useless");
            prefixes.Add("Remarkable");
            prefixes.Add("Cracked");
            prefixes.Add("Chipped");
            prefixes.Add("Bloody");
            prefixes.Add("Terrifying");
            prefixes.Add("Grim");
            prefixes.Add("Blood-Caked");
            prefixes.Add("Amateur's");
            prefixes.Add("Forgettable");
            prefixes.Add("Mediocre");
            prefixes.Add("Intimidating");

            types = new List<string>();
            types.Add("Straight Sword");
            types.Add("Dagger");
            types.Add("Falchion");
            types.Add("Greatsword");
            types.Add("Bastard Sword");
            types.Add("Mail-Breaker");
            types.Add("Dirk");
            types.Add("Knife");
            types.Add("Gladius");
            types.Add("Scimitar");
            types.Add("Axe");
            types.Add("Battleaxe");
            types.Add("Great Axe");
            types.Add("Hammer");
            types.Add("Warhammer");
            types.Add("Scythe");
            types.Add("Mace");
            types.Add("Flanged Mace");
            types.Add("Flail");
            types.Add("Spear");
            types.Add("Trident");
            types.Add("Scepter");
            types.Add("Wand");
            types.Add("Naginata");
            types.Add("Cestus");
            types.Add("Knuckle");
            types.Add("Katar");
            types.Add("Flail");
            types.Add("Bow");
            types.Add("Greatbow");
            types.Add("Crossbow");
            types.Add("Hand-Cannon");
            types.Add("Bandit's Dagger");
            types.Add("Throwing Axe");
            types.Add("Boomerang");
            types.Add("Small Shield");
            types.Add("Wooden Shield");
            types.Add("Buckler");
            types.Add("Kite Shield");
            types.Add("Greatshield");
            types.Add("Pan Lid");
            types.Add("Pitchfork");
            types.Add("Hand Axe");
            types.Add("Shotel");
            types.Add("Flamberge");
            types.Add("Morning Star");

            suffixes = new List<string>();
            suffixes.Add(", the Pustulent");
            suffixes.Add("of Might");
            suffixes.Add("of Annihilation");
            suffixes.Add("of the Damned");
            suffixes.Add("of Sanctity");
            suffixes.Add(", the Untested");
            suffixes.Add(", the Favoured");
            suffixes.Add(", the Warbringer");
            suffixes.Add(", the Truth-Seeker");
            suffixes.Add(", the Ruin");
            suffixes.Add("of the Fifth Sigil");
            suffixes.Add("of the 38 Knights");
            suffixes.Add("of the Favoured");
            suffixes.Add("of Undead-Slaying");
            suffixes.Add("of Beast-Culling");
            suffixes.Add("of Man-Slaying");
            suffixes.Add("the Bizarre");
            suffixes.Add("the Uncanny");
            suffixes.Add("of Nightmares");
            suffixes.Add("of Hell");
            suffixes.Add("of Suffering");
            suffixes.Add("of the Abyss");
            suffixes.Add("of Restoration");
            suffixes.Add("of Miracles");
            suffixes.Add("of Hell's Armies");
            suffixes.Add("of Remorselessness");
            suffixes.Add("of Regret");
            suffixes.Add("of Hopelessness");
            suffixes.Add("of Life-Draining");
            suffixes.Add("of Brutality");
            suffixes.Add("of Savagery");
            suffixes.Add("of Sadism");
            suffixes.Add("of Masochism");
            suffixes.Add("of the Harsh Trials");
            suffixes.Add("of Legends");
            suffixes.Add("of Distinction");
            suffixes.Add("of Uselessness");
            suffixes.Add(", the Unremarkable");
            suffixes.Add("of Distinction");
            suffixes.Add(", Cradle of Hope");
            suffixes.Add(", Hell's Bane");
            suffixes.Add(", Skywarden");
            suffixes.Add(", the Sylphid Breeze");
            suffixes.Add(", the Loyal Servant");
            suffixes.Add(", the Fearsome Tyrant");
            suffixes.Add(", the Godbreaker");
            suffixes.Add(", Thunderforged Nemesis");
            suffixes.Add(", Crucible of the Forgotten");
            suffixes.Add(", Hand of the Deep");

            bool restarting = startCycle();

            while (restarting)
            {
                restarting = startCycle();
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
