using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pokerDesk = new Deck();
            pokerDesk.shuffle(52);
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0, -15}", pokerDesk.DealCard());
                if ((i + 1) % 13 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
