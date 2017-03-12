using CardLib.Enum;
using System;

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

            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }


        /// <summary>
        /// Retrieves the card at teh specified index
        /// </summary>
        /// <param name="cardNum">The card to retrieve</param>
        /// <returns></returns>
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

        /// <summary>
        /// Method to shuffle the cards 
        /// </summary>
        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (!foundCard)
                {
                    destCard = sourceGen.Next(52);
                    if (!assigned[destCard])
                    {
                        foundCard = true;
                    }
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}
