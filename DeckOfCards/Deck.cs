using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck
    {
        public const int No_Of_Cards = 52;
        public Card[] deck;
        private Random ranNo=new Random();
        private int currCard=0;

        public Deck()
        {
            try
            {
                deck = new Card[No_Of_Cards];
                int ct = 0;

                //intialize the deck array with poker cards.

                for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 14; j++)
                    {
                        deck[ct++] = new Card(i, j);
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: " + x.Message + Environment.NewLine + Environment.NewLine + x.StackTrace);
            }
        }
        //shuffle the deck n times
        public void shuffle(int n)
        {
            try
            {
                int i, j, k;

                for (k = 0; k < n; k++)
                {
                    //pick two random cards in a desk..
                    i = ranNo.Next(No_Of_Cards);
                    j = ranNo.Next(No_Of_Cards);

                    //Swap those two random cards.
                    Card tmp = deck[i];
                    deck[i] = deck[j];
                    deck[j] = tmp;
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: " + x.Message + Environment.NewLine + Environment.NewLine + x.StackTrace);
            }

        }
        //deal a Card to Caller.
        public Card DealCard()
        {
            try
            {
                if (currCard < No_Of_Cards)
                {
                    return (deck[currCard++]);
                }
                else
                {
                    Console.WriteLine("Error: Out of cards");
                    return null;
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: " + x.Message + Environment.NewLine + Environment.NewLine + x.StackTrace);
                return null;
            }
        }
       
    }
}
    

