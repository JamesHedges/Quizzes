using Xunit;
using FluentAssertions;
using Practice;
using System;

namespace PracticeTests
{
    public class MinAvgTwoSliceTests
    {
        [Fact]
        public void TestOne()
        {
            int[] testArray = new int[] { 4, 2, 2, 5, 1, 5, 8 };
            MinAvgTwoSlice sut = new MinAvgTwoSlice();
            var result = sut.solution(testArray);
            result.Should().Be(1);
        }

        [Fact]
        public void TestTwo()
        {
            Random rand = new Random();
            int min = -10000;
            int max = 10000;
            int[] testArray = new int[1000];
            for (int i = 0; i < testArray.Length; i++)
                testArray[i] = rand.Next(min, max);
            MinAvgTwoSlice sut = new MinAvgTwoSlice();
            var result = sut.solution(testArray);
            result.Should().Be(1);
        }
    }
}
