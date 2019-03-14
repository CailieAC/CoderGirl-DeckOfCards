using System;

namespace DeckOfCards
{
    public class Deck
    {
        //This is a field, not a property. 
        //Fields should generally not be public. Properties should be public
        private Random random;
        private string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
        private string[] faceValues = { "2", "3", "4", "5", "A" };

        //constructor:
        public Deck()
        {
            random = new Random();
            // TODO: Load the card deck with a standard deck of 52 cards.  
            //Use loops, do not hard code each one.
            Cards = new Card[20];

            for (int i = 0; i < Cards.Length; i++)
            {
                //everything inside this array is a Card (not a string, not faceValue, but an object Card)
                Cards[i] = new Card();
            }

            int cardCount = 0;
            //assign suit
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
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
            // TODO: Return a random card from the deck.
            int randomIndex = random.Next(20);
            Card card = Cards[randomIndex];
            return card;

        }
    }
}