using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDecksWPF
{
    class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; set; }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
