using System;

namespace DeckOfCards
{
    public class Deck
    {
        private Random random;
        private string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
        private string[] faceValues = { "5", "2", "3", "4", "A" };


        public Deck()
        {
            random = new Random();

            Cards = new Card[20];
            for(int i = 0; i< Cards.Length; i++)
            {
                Cards[i] = new Card();
            }

            int cardCount = 0;
            for(int i = 0; i < 4; i++)
            {                
                for(int j = 0; j < 5; j++)
                {
                    Card card = Cards[cardCount];
                    card.Suit = suits[i];
                    card.FaceValue = faceValues[j];
                    cardCount++;
                }
            }
        }

        public Card[] Cards { get; set; }

        public Card Draw()
        {
            int randomIndex = random.Next(0, 20);
            Card card = Cards[randomIndex];
            return card;
        }
    }
}