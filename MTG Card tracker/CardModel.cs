using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_tracker
{
    public class CardModel
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public Uri ImageURI { get; set; }

        public CardModel(string NameIn, string IdIn)
        {
            Name = NameIn;
            try
            {
                Id = Int32.Parse(IdIn);
            } catch(FormatException)
            {
                Id = -1;
            }
        }
    }
}
