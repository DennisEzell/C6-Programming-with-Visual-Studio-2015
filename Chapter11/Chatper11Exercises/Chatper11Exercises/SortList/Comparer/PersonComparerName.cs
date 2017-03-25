using SortList.Class;
using System;
using System.Collections;

namespace SortList.Comparer
{
    public class PersonComparerName : IComparer
    {
        public static IComparer Default = new PersonComparerName();

        public int Compare(object x, object y)
        {
            if(x is Person && y is Person)
            {
                return string.Compare((x as Person).Name, (y as Person).Name);
                //to reverse the order
                //return string.Compare((y as Person).Name, (x as Person).Name);
            }
            else
            {
                throw new ArgumentException("One or both of the objects are not a Person object!");
            }
        }
    }
}
