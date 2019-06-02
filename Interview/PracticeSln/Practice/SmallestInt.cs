using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class SmallestInt
    {
        private readonly List<int> _validInts;

        public SmallestInt()
        {
            _validInts = Enumerable.Range(1, 1000000).Select(n => n).ToList();
        }

        public int solution(int[] A)
        {
            var unique = A.Where(a => a > 0).OrderBy(a => a).Distinct();
            return _validInts.Except(unique).First();
        }
    }
}
