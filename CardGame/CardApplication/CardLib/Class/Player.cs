using CardLib.Collection;
using CardLib.Enum;

namespace CardLib.Class
{
    public class Player
    {
        public string Name { get; private set; }
        public Cards PlayHand { get; private set; }

        private Player() { }

        public Player(string name)
        {
            Name = name;
            PlayHand = new Cards();
        }

        /// <summary>
        /// Simple winning condition if all the player's cards are the same suit
        /// </summary>
        /// <returns>If all the palyer's cards are the same suit</returns>
        public bool HasWon()
        {
            bool won = true;
            Suit match = PlayHand[0].suit;
            PlayHand.ForEach(c => won &= c.suit == match);
            return won;
        }
    }
}
