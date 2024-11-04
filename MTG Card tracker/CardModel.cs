using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_tracker
{
    public class CardModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type_line { get; set; }
        public string oracle_text { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public ImageUris image_uris { get; set; }
        public Prices prices { get; set; }
    }

    public class ImageUris
    {
        public string small { get; set; }
        public string normal { get; set; }
        public string large { get; set; }
    }

    public class Prices
    {
        public string usd { get; set; }
        public string usd_foil { get; set; }
        public string eur { get; set; }
        public string tix { get; set; }
    }

    public class ScryfallResponse
    {
        public List<CardModel> data { get; set; }
        public bool has_more { get; set; }
        public string next_page { get; set; }
    }
}
