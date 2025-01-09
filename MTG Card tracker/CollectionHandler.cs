using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_tracker
{
    public class CollectionHandler
    {
        private readonly List<CardModel> collection;

        public CollectionHandler() 
        {
            collection = LoadCollection();

            if(collection == null )
            {
                collection = new List<CardModel>();
            }
        }

        private List<CardModel> LoadCollection()
        {

            return null;
        }

        public void SaveCollection()
        {

        }

        public void AddCard()
        {

        }
        public void RemoveCard()
        {

        }

        public void SortCollection()
        {

        }
    }
}
