using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Deck
    {
        private static readonly Random Random = new Random();
        private const int NumberOfCards = 52;
        private readonly Card[] deck = new Card[NumberOfCards];
        private int CurrentCard = 0;

        public Deck()
        {
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };
            string[] suits = { "C", "D", "H", "S" };

            for(var count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(suits[count / 13], values[count % 13]);
            }
        }
        public void shuffle()
        {
            CurrentCard = 0;
            for(var first = 0; first < deck.Length; ++first)
            {
                var second = Random.Next(NumberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Card? dealCard()
        {
            if(CurrentCard < deck.Length)
            {
                return deck[CurrentCard++];
            }
            else { 
                return null; 
            }
                
        }
    }
}
