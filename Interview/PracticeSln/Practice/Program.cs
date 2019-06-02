using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "TEST";
            Console.WriteLine("Hello World!");

            RunSmallestInt();

            //Console.ReadLine();
        }

        private static void RunSmallestInt()
        {
            var solution = new SmallestInt();
            ShowSmallestIntAnswer(solution, new[] { -1, 0, 1, 3, 8, 2, 1, -10, 4 });
        }

        private static void ShowSmallestIntAnswer(SmallestInt solution, int[] ints)
        {
            var answer = solution.solution(ints);
            Console.WriteLine($"The answer is {answer}");
        }
    }
}
