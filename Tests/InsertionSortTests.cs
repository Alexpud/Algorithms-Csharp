using System;
using Xunit;
using Algorithms.Algorithms;

namespace Algorithms.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void Should_Order_Empty_List()
        {
            Assert.Equal(InsertionSort.Sort(new int[0]), new int[0]);
        }

        [Fact]
        public void Should_Order_List_With_1_Element()
        {
            int [] array = {1};
            Assert.Equal(InsertionSort.Sort(array), array);
        }

        [Fact]
        public void Should_Order_Worst_Case()
        {
            int [] inputArray = { 6, 5, 4, 3, 2, 1 };
            int [] outputArray = { 1, 2, 3, 4, 5, 6};
            Assert.Equal(InsertionSort.Sort(inputArray), outputArray);
        }
    }
}