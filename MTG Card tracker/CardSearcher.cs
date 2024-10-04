using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MTG_Card_tracker
{
    public class CardSearcher
    {
        public async Task SearchScryfall(string searchTerm = null)
        {
            string url = null;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string encodedSearch = HttpUtility.UrlEncode(searchTerm);
                url = $"https://api.scryfall.com/cards/search?order=cmc&q={encodedSearch}";
            }
        }
    }
}
