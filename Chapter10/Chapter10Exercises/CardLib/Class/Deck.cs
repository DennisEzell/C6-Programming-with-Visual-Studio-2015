using static System;
using CardLib.Enum;

namespace CardLib.Class
{
    public class Deck
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Card[] cards;

        /// <summary>
        /// Constrctor
        /// </summary>
        public Deck()
        {
            cards = new Card[52];

            for (int suitVal = 0; suitVal < 4, suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        /// <summary>
        /// Methods
        /// </summary>

        public Card getCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
            }
        }
    }
}
