namespace DeckOfCards
{
    public class Card
    {
        public FaceValue FaceValue { get; private set; }
        public Suit Suit { get; private set; }

        public Card(FaceValue faceValue, Suit suit)
        {
            FaceValue = faceValue;
            Suit = suit;
        }

        public string GetFullName()
        {
            return $"{FaceValue} of {Suit}";
        }
    }
}