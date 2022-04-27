using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Hand
    {
        Card[] holdEmHand = new Card[2];

        public Hand()
        {
            Deck deck = new Deck();
            deck.shuffle();
            for(int i = 0; i < holdEmHand.Length; i++)
            {
                holdEmHand[i] = deck.dealCard();
            }
        }

        public void dealHoldemHand()
        {
            foreach(Card card in holdEmHand)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
