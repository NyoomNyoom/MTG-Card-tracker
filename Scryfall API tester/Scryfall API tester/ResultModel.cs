using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scryfall_API_tester
{
    public class ResultModel
    {
        public String? Object { get; set; }
        public String? Next_page { get; set; }
        public int Total_cards { get; set; }
        public bool Has_more { get; set; }
    }
}
