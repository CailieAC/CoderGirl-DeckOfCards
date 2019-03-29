using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public static class Program
    {
        public static void Main()
        {
            Deck deck = new Deck();
            
            var card = deck.PickRandomCard();
            
            Console.WriteLine(card.GetFullName());
            Console.ReadLine();
        }
    }
}