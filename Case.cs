// namespace stairway
// {
//     internal class Case
//     {
//     }
// }

using System;
using System.Linq;
using System.Collections.Generic;

namespace stairway
{
    public class Case
    {
        public IEnumerable<int> Costs { get; init; }
        public int Result { get; init; }

        public static Case Case1() 
        {
            return new Case()
            {
                Costs = new int[] { 1, 1, 100, 1, 1 },
                Result = 2
            };
        }

        public static Case Case2() 
        {
            return new Case()
            {
                Costs = new int[] { 1, 1, 100, 1000, 1 },
                Result = 102
            };
        }

        public static Case Case3() 
        {
            return new Case()
            {
                Costs = new int[] { 1, 1, 100, 1000, 1, 10, 1, 10, 1, 10, 1 },
                Result = 105
            };
        }
    }
}
