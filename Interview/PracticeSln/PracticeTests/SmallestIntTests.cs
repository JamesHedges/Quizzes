using System;
using Xunit;
using FluentAssertions;
using Practice;

namespace PracticeTests
{
    public class SmallestIntTests
    {
        [Fact]
        public void Test1()
        {
            var solution = new SmallestInt();
            int[] ints = new[] { -1, 0, 1, 3, 8, 2, 1, -10, 4 };
            var answer = solution.solution(ints);
            answer.Should().Be(5);
        }
    }
}
