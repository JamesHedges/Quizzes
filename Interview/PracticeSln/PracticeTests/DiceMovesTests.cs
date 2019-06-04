using Xunit;
using FluentAssertions;
using Practice;

namespace PracticeTests
{
    public class DiceMovesTests
    {
        [Fact]
        public void TestOne()
        {
            DiceMoves solution = new DiceMoves();
            int[] test = new[] { 1,2,3 };
            var result = solution.solution(test);
            result.Should().Be(2);
        }

        [Fact]
        public void TestTwo()
        {
            DiceMoves solution = new DiceMoves();
            int[] test = new[] { 1,1,6 };
            var result = solution.solution(test);
            result.Should().Be(2);
        }

        [Fact]
        public void TestThree()
        {
            DiceMoves solution = new DiceMoves();
            int[] test = new[] { 1,6,2,3};
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestFour()
        {
            DiceMoves solution = new DiceMoves();
            int[] test = new[] { 1,6, 6,2,3};
            var result = solution.solution(test);
            result.Should().Be(6);
        }

        [Fact]
        public void TestFive()
        {
            DiceMoves solution = new DiceMoves();
            int[] test = new[] { 1,1,6, 6,2,3, 1};
            var result = solution.solution(test);
            result.Should().Be(6);
        }
    }
}
