using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Player
    {
        private string firstName;
        private string lastName;

        public List<Card> Hand { get; set; }
        public string FullName
        {
            get { return $"{lastName}, {firstName}"; }
        }

        public Player(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Hand = new List<Card>();
        }

        public Player(string firstName, string lastName, List<Card> startingHand)
        {
            this.Hand = startingHand;
        }     
        
    }
}
