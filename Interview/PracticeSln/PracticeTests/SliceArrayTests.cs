using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;
using Practice;
using System;

namespace PracticeTests
{

    public class SliceArrayTests
    {
        [Fact]
        public void TestOne()
        {
            SliceArray slice = new SliceArray();
            int[] test = new[] {5,4,4,5,0,12 };
            var result = slice.solution(test);
            result.Should().Be(4);
        }

        [Theory]
        [InlineData(new[] { 5, 4, 4, 5, 0, 12 }, 4)]
        [InlineData(new[] { 3, 4, 5, 5, 2 }, 4)]
        public void TestTwo(int[] test, int expected)
        {
            SliceArray slice = new SliceArray();
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
