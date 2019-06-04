using System.Linq;

namespace Practice
{
    public class DiceMoves
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
}
