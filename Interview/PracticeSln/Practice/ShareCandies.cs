using System.Linq;

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
    public class ShareCandies
    {
        public ShareCandies()
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
}
