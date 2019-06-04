using Xunit;
using FluentAssertions;
using Practice;

namespace PracticeTests
{
    public class ShareCandiesTests
    {
        [Fact]
        public void TestOne()
        {
            ShareCandies solution = new ShareCandies();
            int[] test = new[] { 3, 4, 7, 7, 6, 6 };
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestTwo()
        {
            ShareCandies solution = new ShareCandies();
            int[] test = new[] { 80,80,1000000,80,80,80,80,80,80,123456789};
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestThree()
        {
            ShareCandies solution = new ShareCandies();
            int[] test = new[] { 80,80,1000000, 123456789};
            var result = solution.solution(test);
            result.Should().Be(2);
        }
    }
}
