﻿using CardLib.Enum;
using System;

namespace CardLib.Class
{
    /// <summary>
    /// Class to represent individual cards
    /// Note: That the static field values apply to all Card instances as once they are set
    ///       they should be that same value for any card 
    /// </summary>
    public class Card : ICloneable
    {
        /// <summary>
        /// suit and rank are readonly because they should only be set in the constructor when a new card is created.
        /// You cant change the suit and rank of a card in a deck.
        /// </summary>
        public readonly Suit suit;
        public readonly Rank rank;
        
        /// <summary>
        /// Flag for usage. If true, trumps are valued higher than cards of other suits
        /// </summary>
        public static bool usesTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true
        /// </summary>
        public static Suit trump = Suit.Club;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower than dueces
        /// </summary>
        public static bool isAceHigh = true;

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

        /**
         * This section contains operator overloads for the Card Class
         * This section was added based on examples from the Chapter 11 operator
         * overload section @ page 286
        */
        public static bool operator ==(Card card1, Card card2) 
            => (card1?.suit == card2?.suit) && (card1?.rank == card2?.rank);

        public static bool operator !=(Card card1, Card card2)
            => !(card1 == card2);

        public override bool Equals(object card) => this == (card as Card);

        public override int GetHashCode() => 13 * (int)rank + (int)suit;
        
        public static bool operator > (Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return !(card2.rank == Rank.Ace);//If card1 is an Ace but not card2
                    }//End card1 == Ace
                    else
                    {
                        return (card2.rank == Rank.Ace)
                            ? false  //Neither car is an ace
                            : (card1.rank > card2?.rank);//If card1 & card2 are not aces, directly compare ranks since aces arent an issue

                    }
                }//End isAceHigh
                else
                {
                    return (card1.rank > card2?.rank);//Aces arent high, so just compare the ranks
                }
            }//End cards are the same suit
            else
            {
                return !(usesTrumps && (card2.suit == Card.trump));//Must not be playing poker???                
            }
        }

        public static bool operator < (Card card1, Card card2) => !(card1 >= card2);

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if(card1.rank == Rank.Ace)
                    {
                        return true;
                    }//end card1 is an ace
                    else
                    {
                        return (card2.rank == Rank.Ace)
                            ? false
                            : (card1.rank >= card2.rank);
                    }
                }//end isAceHigh
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                return !(usesTrumps && (card2.suit == Card.trump));
            }
        }

        public static bool operator <= (Card card1, Card card2) => !(card1 >  card2);
    }
}
