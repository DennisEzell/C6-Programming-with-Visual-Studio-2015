using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses.Class
{
    public class Outer
    {
        private int state = -1;
        public int State
        {
            get { return state; }
        }

        /// <summary>
        /// Nested Class
        /// </summary>
        public class Nested
        {
            public void SetPrivateState(Outer target, int newState)
            {
                target.state = newState;
            }
        }
    }
}
