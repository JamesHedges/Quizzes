using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    /*
        A non-empty array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P < Q < N, is called a slice of array A (notice that the slice contains at least two elements). The average of a slice (P, Q) is the sum of A[P] + A[P + 1] + ... + A[Q] divided by the length of the slice. To be precise, the average equals (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).
        For example, array A such that:
            A[0] = 4
            A[1] = 2
            A[2] = 2
            A[3] = 5
            A[4] = 1
            A[5] = 5
            A[6] = 8 
        contains the following example slices:
        slice (1, 2), whose average is (2 + 2) / 2 = 2;
        slice (3, 4), whose average is (5 + 1) / 2 = 3;
        slice (1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.

        The goal is to find the starting position of a slice whose average is minimal.

        Write a function:
        class Solution { public int solution(int[] A); }
        that, given a non-empty array A consisting of N integers, returns the starting position of the slice with the minimal average. If there is more than one slice with a minimal average, you should return the smallest starting position of such a slice.
        For example, given array A such that:
            A[0] = 4
            A[1] = 2
            A[2] = 2
            A[3] = 5
            A[4] = 1
            A[5] = 5
            A[6] = 8 
        the function should return 1, as explained above.
        Write an efficient algorithm for the following assumptions:  
            - N is an integer within the range [2..100,000];
            - each element of array A is an integer within the range [−10,000..10,000].        
    */

    public class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            //return CalcWithSpan(A);
            return CalcIt4(A);
        }

        private List<(int P, int Q)> GetSlices(int length)
        {
            var slices = new List<(int P, int Q)>();
            for (int left = 0; left < length; left++)
                for (int right = left+1; right < length; right++)
                    slices.Add((left, right));

            return slices;
        }

        private int CalcWithSpan(int[] A)
        {
            var slices = GetSlices(A.Length);
            var t = slices
                .Select(s => new { s.P, s.Q, Slice = new Span<int>(A, s.P, s.Q - s.P + 1).ToArray() })
                .Select(sp => new { sp.P, sp.Q, Avg = (decimal)(sp.Slice.Sum()) / (sp.Slice.Length) })
                .OrderBy(n => n.Avg)
                .First();
            return t.P;
        }

        private int CalcIt(int[] ints)
        {
            int length = ints.Length;
            decimal min = 10001;
            int startMin = 0;
            for (int left = 0; left < length; left++)
                for (int right = left + 1; right < length; right++)
                {
                    var sum = 0;
                    for (int i = left; i <= right; i++)
                        sum += ints[i];
                    var avg = (decimal)sum / (right - left + 1);
                    if (avg < min)
                    {
                        startMin = left;
                        min = avg;
                    }
                }
            return startMin;
        }

        private int CalcIt2(int[] ints)
        {
            int length = ints.Length;
            decimal min = 10001;
            int startMin = 0;
            for (int left = 0; left < length; left++)
                for (int right = left + 1; right < length; right++)
                {
                    var avg = AvgIt(ints, left, right);
                    if (avg < min)
                    {
                        startMin = left;
                        min = avg;
                    }
                }
            return startMin;
        }

        private int CalcIt3(int[] ints)
        {
            int length = ints.Length;
            decimal min = 10001;
            Func<int[], int, int, decimal> avgIt = (s, l, r) =>
            {
                var sum = 0;
                for (int i = l; i <= r; i++)
                    sum += s[i];
                return (decimal)sum / (r - l + 1);
            };
            int startMin = 0;
            for (int left = 0; left < length; left++)
                for (int right = left + 1; right < length; right++)
                {
                    var avg = avgIt(ints, left, right);
                    if (avg < min)
                    {
                        startMin = left;
                        min = avg;
                    }
                }
            return startMin;
        }

        private int CalcIt4(int[] ints)
        {
            int answer;
            int? minAnswer = null;
            int minRow = -1;
            Span<int> span = new Span<int>(ints);
            for(int row = 0; row < ints.Length; row++)
            {
                for (int col = row+1; col < ints.Length; col++)
                {
                    var slice = span.Slice(row, col - row + 1);
                    answer = 0;
                    foreach(int i in slice)
                    {
                        answer += i;
                    }
                    if (!minAnswer.HasValue || answer < minAnswer.Value)
                    {
                        minAnswer = answer;
                        minRow = row;
                    }
                }
            }

            return minRow;
        }

        private decimal SumIt(int[] ints, int left, int right)
        {
            var sum = 0;
            for (int i = left; i <= right; i++)
                sum += ints[i];
            return (decimal)sum;
        }

        private decimal AvgIt(int[] ints, int left, int right)
        {
            var sum = 0;
            for (int i = left; i <= right; i++)
                sum += ints[i];
            return (decimal)sum / (right - left + 1);
        }
    }
}
