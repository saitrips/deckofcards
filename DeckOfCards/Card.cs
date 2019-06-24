using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
   public class Card
    {
        public enum CardFace
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }
        public enum CardSuit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spades = 4
        }
        public CardSuit Suit { get; set; }
        public CardFace Face { get; set; }

      
        public Card(int csuit, int cface)
        {

            Suit = (CardSuit)csuit;
            Face = (CardFace)cface;
        }
        public override string ToString()
        {            
            return Suit + ":" + Face;
        }
    }
}
