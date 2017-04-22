using CardLib.Collection;
using CardLib.Enum;
using System;

namespace CardLib.Class
{
    public class Deck : ICloneable
    {
        /// <summary>
        /// Event to reshuffle the deck when last card is drawn
        /// Implemented based on Chapter 13, @page 358
        /// </summary>
        public event EventHandler LastCardDrawn;

        /// <summary>
        /// Fields
        /// </summary>
        private Cards cards = new Cards();

        /// <summary>
        /// Constrctor
        /// </summary>
        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        /// <summary>
        /// Single Arg constructor used when cloning a Deck.
        /// See Clone() method below
        /// </summary>
        /// <param name="newCards"></param>
        public Deck(Cards newCards)
        {
            cards = newCards;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high
        /// </summary>
        /// <param name="isAceHigh"></param>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows trumps to be set
        /// </summary>
        /// <param name="usesTrumps"></param>
        /// <param name="trump"></param>
        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.usesTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump): this()
        {
            Card.isAceHigh = isAceHigh;
            Card.usesTrumps = useTrumps;
            Card.trump = trump;
        }


        /// <summary>
        /// Retrieves the card at teh specified index
        /// </summary>
        /// <param name="cardNum">The card to retrieve</param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                {
                    LastCardDrawn(this, EventArgs.Empty);
                }
                return cards[cardNum];
            }
            else
            {
                throw (new ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
            }
        }

        /// <summary>
        /// Method to shuffle the cards 
        /// </summary>
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (!foundCard)
                {
                    sourceCard = sourceGen.Next(52);
                    if (!assigned[sourceCard])
                    {
                        foundCard = true;
                    }
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }

        /// <summary>
        /// Clone method to return a new deck of cards with a new Cards collection.
        /// See the Cards.Clone() method for details on how this is a Deep Copy
        /// instead of a Shallow Copy.
        /// </summary>
        /// <returns></returns>
        public object Clone() => new Deck(cards.Clone() as Cards);
    }
}
