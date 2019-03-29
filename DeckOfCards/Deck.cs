using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Card> Cards { get; set; }

        public Deck()
        {
            AddCardsToDeck();
            Shuffle();
        }
        
        /// <summary>
        /// Look at a random card in the deck
        /// </summary>
        /// <returns></returns>
        public Card PickRandomCard()
        {
            int randomIndex = random.Next(0, Cards.Count);
            Card card = Cards[randomIndex];
            return card;
        }

        /// <summary>
        /// Draw a card from the deck
        /// </summary>
        /// <returns></returns>
        public Card DrawCard()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Draw cards out of the deck
        /// </summary>
        /// <param name="number">Number of cards to draw</param>
        /// <returns></returns>
        public List<Card> DrawCards(int number)
        {
            List<Card> drawnCards = Cards.Take(number).ToList();
            Cards.RemoveAll(card => drawnCards.Contains(card));
            return drawnCards;
        }

        /// <summary>
        /// Will take a number of cards from the top of the deck and place them on the bottom
        /// </summary>
        /// <param name="number">number of cards to take from top</param>
        public void CutDeck(int number)
        {
            List<Card> bottomCut = Cards.TakeLast(number).ToList();
            Cards.RemoveRange(0, number);
            Cards.AddRange(bottomCut);
        }

        /// <summary>
        /// Shuffle using the Fisher Yates algorithm
        /// <see cref="https://www.dotnetperls.com/fisher-yates-shuffle"/>
        /// </summary>
        public void Shuffle()
        {
            random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randomIndex = i + random.Next(Cards.Count - i);
                Card cardToSwap = Cards[randomIndex];
                Cards[randomIndex] = Cards[i];
                Cards[i] = cardToSwap;
            }

        }

        public List<Card> GetCardsOfSuit(Suit suit)
        {
            var cardsOfSuit = Cards.Where(card => card.Suit == suit).ToList();
            return cardsOfSuit;
        }

        public List<Card> GetCardsOfFaceValue(FaceValue faceValue)
        {
            var cardsOfFaceValue = Cards.Where(card => card.FaceValue == faceValue).ToList();
            return cardsOfFaceValue;
        }

        private void AddCardsToDeck()
        {
            Cards = new List<Card>();

            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                {
                    Card card = new Card(faceValue, suit);
                    Cards.Add(card);
                }
            }
        }
    }
}