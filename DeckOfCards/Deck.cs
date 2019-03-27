using System;

namespace DeckOfCards
{
    public enum Suit
    {
        Hearts,
        Spades,
        Clubs, 
        Diamonds
    }

    public enum FaceValue
    {
        Two,
        Three,
        Four,
        Five, 
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Deck
    {
        private Random random;
        //replace with enums
        //private string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
        //private string[] faceValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public Deck()
        {
            AddCardsToDeck();
            Shuffle();
        }

        public Card[] Cards { get; set; }

        public Card Draw()
        {
            int randomIndex = random.Next(0, 20);
            Card card = Cards[randomIndex];
            return card;
        }

        /// <summary>
        /// Shuffle using the Fisher Yates algorithm
        /// <see cref="https://www.dotnetperls.com/fisher-yates-shuffle"/>
        /// </summary>
        public void Shuffle()
        {
            random = new Random();
            int deckSize = Cards.Length;
            for (int i = 0; i < deckSize; i++)
            {
                int index = i + random.Next(deckSize - i);
                Card cardToSwap = Cards[index];
                Cards[index] = Cards[i];
                Cards[i] = cardToSwap;
            }

        }

        private void AddCardsToDeck()
        {
            int deckSize = 52;
            Cards = new Card[deckSize];

            int cardIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    /*
                    Card card = new Card
                    {
                        Suit = suits[i],
                        FaceValue = faceValues[j]
                    };
                    */

                    //Card card = new Card { Suit = suits[i], FaceValue = faceValues[j] };
                    //more spaced out version below is good for when you have a lot more properties
                    /*
                    Card card = new Card {
                        Suit = suits[i],
                        FaceValue = faceValues[j]
                    };
                    */

                    Card card = new Card(FaceValue.Ace, Suit.Hearts);
                    Cards[cardIndex] = card;

                    cardIndex++;
                }
            }
        }
    }
}