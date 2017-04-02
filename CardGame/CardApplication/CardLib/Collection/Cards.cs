using CardLib.Class;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CardLib.Collection
{
    /// <summary>
    /// Changed extending from CollectionBase to Generic -> List<Card>
    /// This eliminated the need to implement the methods that are commented out.
    /// </summary>
    public class Cards : List<Card> /*CollectionBase*/, ICloneable
    {
        /// <summary>
        /// Utility method for copying card instances into another Cards instance
        /// used in Deck.Shuffle(). This implementation assumes that source 
        /// and target collections are the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Have to provide more implementation than just MemberwiseClone() since
        /// we are dealing with Card objects and do not want shallow copy references 
        /// in the returned new Cards object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card card in this)
            {
                //newCards.Add(new Card(card.suit, card.rank));      
                newCards.Add((Card)card.Clone());          
            }

            return newCards;
        }

        //public void Add(Card card)
        //{
        //    List.Add(card);
        //}

        //public void Remove(Card card)
        //{
        //    List.Remove(card);
        //}

        //public Card this[int cardIndex]
        //{
        //    get { return (Card)List[cardIndex]; }
        //    set { List[cardIndex] = value; }
        //}

        /// <summary>
        /// Utility method to determine if the Cards array contains the card argument
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        //public bool ContainsCard(Card card) => InnerList.Contains(card);
    }
}
