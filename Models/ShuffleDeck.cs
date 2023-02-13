using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Deck_of_Cards_API_Lab.Models
{
    public partial class ShuffleDeck
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public Card[] Cards { get; set; }
        public long Remaining { get; set; }
    }

    public partial class Card
    {
        public string Code { get; set; }
        public Uri Image { get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public partial class Images
    {
        public Uri Svg { get; set; }
        public Uri Png { get; set; }
    }
}

