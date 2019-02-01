using System.Collections.Generic;

namespace YYTEstimator
{
    public class Card
    {
        public string ID { get; set; }
        public string Translation { get; set; }
        public int Amount { get; set; }
        public string URL { get; set; }
        public int Price { get; set; }
        public string YytSetCode { get; set; }
        public string Rarity { get; set; }
        public string CardURL { get; set; }
        public bool EBFoil { get; set; }

        public static List<Card> Cards;
    }
}