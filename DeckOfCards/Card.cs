namespace DeckOfCards
{
    public class Card
    {
        //properties are almost always public (rare exceptions), and capitalized
        public string FaceValue { get; set; }

        public string Suit { get; set; }

        public string GetFullName()
        {
            // TODO: Return the full name of the card. Ex: 2 of Hearts
            return $"{FaceValue} of {Suit}";
        }
    }
}