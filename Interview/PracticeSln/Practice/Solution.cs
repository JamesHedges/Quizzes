using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    /*
     *  N Candies represented by an integer
     *  N is even, share half
     *  
     *  Needs to have maximum number of different type left over
     *  
     *  Given an array on N integers representingall the types
     *  return the max number she can eat after giving away half
     *  
     *  n is 2-100000
     *  n is even
     *  each element is 1 - 1000000
     *  
     *  n/2 = number to give away
     *  t = to the number of types
     *  tn = the number of each type
     *  a.groupby(n)
    */
    public class Solution
    {
        public Solution()
        {

        }

        public int solution(int[] T)
        {
            int give = 0;
            int keepTypeCount = 0;

            int numToGiveAway = T.Length / 2;
            var groups = T.GroupBy(t => t)
                .Select(tg => new { CandyType
                = tg.Key, NumType = tg.Count(), Give = tg.Count()-1, Keep = (tg.Count() - tg.Count()-1) })
                .OrderByDescending(tg => tg.NumType);
            foreach(var candie in groups)
            {
                if (give < numToGiveAway)
                {
                    give += candie.Give > 0 ? candie.Give : 1;
                    if (candie.Give == 0)
                        keepTypeCount--;
                }
                keepTypeCount++;
                
            }
            return keepTypeCount;
        }

    }

    public class Solution2
    {
        public int solution(int[] A)
        {
            int moves = 0;

            var b = OrderDice(A);
            int target = b[0];
            for(var i = 0; i < b.Length; i++)
            {
                if (b[i] != target)
                {
                    if (b[i] + target == 7)
                        moves++;
                    moves++;
                }
            }
            return moves;
        }

        private int[] OrderDice(int[] A)
        {

            return A.Select(a => new { die = a, cnt = A.Sum(aa => a + aa == 7 ? 1 : 0) })
                .OrderBy(m => m.cnt)
                .Select(m => m.die)
                .ToArray();
        }
    }

    public class Slice
    {
        // slice if 0 <= p <= q < N for a (p,q)
        // bi-valued if number of slices 2 or less
        // array of n integers [5,4,4,5,0,12] has 4
        // (5,4), (5, 4), (5,5), (5,0), (5,12)
        // (4,5), (4,4), (4,5), (4, 0), (4,12)

        public int solution(int[] A)
        {
            var pairs = GetPairs(A);

            var slices = pairs.Where(p => 0 <= p.P && p.P <= p.Q && p.Q < A.Length);
            return slices.Distinct(new PQComparer()).Count();
        }

        private List<PQ> GetPairs(int[] A)
        {
            var result = new List <PQ>();
            for (int left = 0; left < A.Length; left++)
                for (int right = left; right < A.Length; right++)
                    result.Add(new PQ { P = A[left], Q = A[right] });
            return result;
        }

        public class PQComparer : IEqualityComparer<PQ>
        {
            public bool Equals(PQ x, PQ y)
            {
                if (x == null && y == null)
                    return true;
                if (x == null || y == null)
                    return false;
                return (x.P == y.P && x.Q == y.Q || x.P == y.Q && x.Q == y.P);
            }

            public int GetHashCode(PQ obj)
            {
                return (obj.P * obj.Q).GetHashCode();
            }
        }

        public class PQ
        {
            public int P { get; set; }
            public int Q { get; set; }

            public override string ToString()
            {
                return $"({P},{Q})";
            }
        }
    }

    public class HashTest
    {
        public int[] solution(int[] ints)
        {
            HashSet<int> hashSet = new HashSet<int>(ints);
            int[] result = new int[hashSet.Count];
            hashSet.CopyTo(result);
            return result;
        }
    }
}
