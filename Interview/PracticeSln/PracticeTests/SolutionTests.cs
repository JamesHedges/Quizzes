using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;
using Practice;

namespace PracticeTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestOne()
        {
            Solution solution = new Solution();
            int[] test = new[] { 3, 4, 7, 7, 6, 6 };
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestTwo()
        {
            Solution solution = new Solution();
            int[] test = new[] { 80,80,1000000,80,80,80,80,80,80,123456789};
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestThree()
        {
            Solution solution = new Solution();
            int[] test = new[] { 80,80,1000000, 123456789};
            var result = solution.solution(test);
            result.Should().Be(2);
        }
    }

    public class Solution2Tests
    {
        [Fact]
        public void TestOne()
        {
            Solution2 solution = new Solution2();
            int[] test = new[] { 1,2,3 };
            var result = solution.solution(test);
            result.Should().Be(2);
        }

        [Fact]
        public void TestTwo()
        {
            Solution2 solution = new Solution2();
            int[] test = new[] { 1,1,6 };
            var result = solution.solution(test);
            result.Should().Be(2);
        }

        [Fact]
        public void TestThree()
        {
            Solution2 solution = new Solution2();
            int[] test = new[] { 1,6,2,3};
            var result = solution.solution(test);
            result.Should().Be(3);
        }

        [Fact]
        public void TestFour()
        {
            Solution2 solution = new Solution2();
            int[] test = new[] { 1,6, 6,2,3};
            var result = solution.solution(test);
            result.Should().Be(6);
        }

        [Fact]
        public void TestFive()
        {
            Solution2 solution = new Solution2();
            int[] test = new[] { 1,1,6, 6,2,3, 1};
            var result = solution.solution(test);
            result.Should().Be(6);
        }
    }

    public class SliceTest
    {
        [Fact]
        public void TestOne()
        {
            Slice slice = new Slice();
            int[] test = new[] {5,4,4,5,0,12 };
            var result = slice.solution(test);
            result.Should().Be(4);
        }

        [Theory]
        [InlineData(new[] { 5, 4, 4, 5, 0, 12 }, 4)]
        [InlineData(new[] { 3, 4, 5, 5, 2 }, 4)]
        public void TestTwo(int[] test, int expected)
        {
            Slice slice = new Slice();
            var result = slice.solution(test);
            result.Should().Be(expected);
        }
    }

    public class HashTestTests
    {
        [Fact]
        public void TestOne()
        {
            HashTest sut = new HashTest();
            //int[] test = new[] {5,4,4,5,0,12 };
            int[] test = new[] {3,4,5,5,2 };
            int[] expected = new[] { 3, 4, 5, 2 };
            var result = sut.solution(test);
            result.SequenceEqual(expected).Should().BeTrue();
        }

    }
}
