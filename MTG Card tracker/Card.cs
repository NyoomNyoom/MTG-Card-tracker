using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_tracker
{
    class Card()
    {
        private readonly string name;
        private readonly string manaCost;
        public Card(string nameIn, string manaCostIn): this()
        {
            name = nameIn;
            manaCost = manaCostIn;
        }

        public string getName()
        {
            return name;
        }

        public string getManaCost()
        {
            return manaCost;
        }
    }
}
