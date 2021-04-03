using System;
using System.Linq;
using System.Collections.Generic;

namespace stairway
{
    class Program
    {
        static int _tryStepInvocations = 0;
        static int[] _partialResults;

        static void Main(string[] args)
        {
            var input = Case.Case3().Costs;
            _partialResults = Enumerable.Range(0,input.Count() + 1)
                .Select(_ => -1)
                .ToArray();
            var result = TryStep(0, 1, input);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Invocations: {_tryStepInvocations}");
        }

        static int TryStep(int candidate1Idx, int candidate2Idx, IEnumerable<int> costs)
        {
            if (_partialResults[candidate1Idx] > 0)
            {
                return _partialResults[candidate1Idx];
            }
            ++_tryStepInvocations;
            var candidate1Result = 0;
            if (candidate1Idx < costs.Count())
            {
                candidate1Result = costs.ElementAt(candidate1Idx) 
                    + TryStep(candidate1Idx + 1, candidate1Idx + 2, costs);
            }

            var candidate2Result = 0;
            if (candidate2Idx < costs.Count())
            {
                candidate2Result = costs.ElementAt(candidate2Idx) 
                    + TryStep(candidate2Idx + 1, candidate2Idx + 2, costs);
            }

            var result = candidate1Result < candidate2Result ? candidate1Result : candidate2Result;
            _partialResults[candidate1Idx] = result;
            return result;
        }
    }
}
