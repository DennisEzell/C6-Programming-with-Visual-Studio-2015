using CardLib.Enum;

namespace CardLib.Class
{
    public class Card
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
    }
}
