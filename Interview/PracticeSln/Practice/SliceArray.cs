using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{

    public class SliceArray
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
