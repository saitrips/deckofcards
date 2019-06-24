using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;
namespace DOCTests
{

    [TestClass]
    public class DeckTests
    {
        public Deck pokerDesk = new Deck();

        //This test checks the card count is equal 52.
        [TestMethod]
        public void CheckCardCount()
        {

            int cardCount = pokerDesk.deck.Length;
            Assert.AreEqual(52, cardCount);
        }
        //This test will check if the shuffled Deck is different in order than that of original deckofcards.
        [TestMethod]
        public void CheckShuffle()
        {

            bool isdeckDifferent = false;

            Deck tempDeck = new Deck();

            tempDeck.shuffle(52);

            for (int i = 0; i < tempDeck.deck.Length; i++)
            {
                if (tempDeck.deck[i].Suit != pokerDesk.deck[i].Suit || tempDeck.deck[i].Face != pokerDesk.deck[i].Face)
                {

                    isdeckDifferent = true;
                    break;
                }
            }
            Assert.IsTrue(isdeckDifferent);
        }
        //Method to check if the dealcard return no card if caller makes 53rd call.
        [TestMethod]
        public void CheckdealCard()
        {
            int indexoutofbound = 53;
            Card dealcard = new Card(1, 1);
            for (int i = 0; i < indexoutofbound; i++)
            {
                dealcard = pokerDesk.DealCard();
            }
            Assert.AreEqual(dealcard, null);
        }
    }
}
