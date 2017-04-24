using System;
using System.Collections;


namespace Extensions
{
    public static class Extension 
    {
        public static void RepeatAction(this IEnumerable source)
        {
            foreach (var item in source)
            {
                (item as Action).Invoke();
            }
        }


    }
}
