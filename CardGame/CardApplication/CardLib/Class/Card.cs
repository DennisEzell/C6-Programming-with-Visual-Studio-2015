using CardLib.Enum;
using System;

namespace CardLib.Class
{
    public class Card : ICloneable
    {
        /// <summary>
        /// suit and rank are readonly because they should only be set in the constructor when a new card is created.
        /// You cant change the suit and rank of a card in a deck.
        /// </summary>
        public readonly Suit suit;
        public readonly Rank rank;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        private Card() { }

        public override string ToString()
        {
            return $"The {rank} of {suit}s";
        }

        /// <summary>
        /// This is the implementation of the required method from IClonable
        /// The MemberwiseClone is sufficient here since we do not have to worry with
        /// object references, only Enums which are, by default, value references.
        /// </summary>
        /// <returns></returns>
        public object Clone() => MemberwiseClone();
    }
}
