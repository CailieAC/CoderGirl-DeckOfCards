namespace DeckOfCards
{
    public class Card
    {
        public string FaceValue { get; set; }

        public string Suit { get; set; }

        public string GetFullName()
        {
            string fullName = $"{FaceValue} of {Suit}";
            return fullName;
        }
    }
}