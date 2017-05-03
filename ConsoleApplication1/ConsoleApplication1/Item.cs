using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    public class Item
    {
        private string type;
        private string prefix;
        private string suffix;

        public int rarity;
        public int maximumRarity;

        private Random r;

        public string displayText;
        
        public Item(string prefix, string type, string suffix, Random r, int maximumRarity)
        {
            this.prefix = prefix;
            this.type = type;
            this.suffix = suffix;
            this.r = r;
            this.maximumRarity = maximumRarity;

            displayText = generateDisplayText();
        }

        private string generateDisplayText()
        {
            string newDisplayText = "";

            //First, determine what quality of item we're going to generate randomly.
            //Higher is better.
            rarity = r.Next(maximumRarity);

            switch (rarity)
            {
                case 0:
                    //Broken, only shows type
                    newDisplayText = type;
                    break;
                case 1:
                    //Normal, only shows type
                    newDisplayText = type;
                    break;
                case 2:
                    //Fine, displays prefix and type
                    newDisplayText = prefix + " " + type;
                    break;
                case 3:
                    //Exceptional, displays prefix, type, and suffix.
                    if(suffix[0] == ',')
                    {
                        newDisplayText = prefix + " " + type + suffix;
                    }else
                    {
                        newDisplayText = prefix + " " + type + " " + suffix;
                    }
                    break;
                case 4:
                    //Epic
                    if (suffix[0] == ',')
                    {
                        newDisplayText = "Unique" + " " + type + suffix;
                    }
                    else
                    {
                        newDisplayText = "Unique" + " " + type + " " + suffix;
                    }
                    break;
            }

            return newDisplayText;
        }
    }
}
