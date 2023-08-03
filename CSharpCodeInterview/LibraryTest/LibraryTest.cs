namespace test_library;

using Library;
using Xunit;

public class TestCSharpCodeInterview
{
    [Fact]
    public void TestThing()
    {
        Assert.Equal(42, Thing.Get(19, 23));
    }

    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
    */
    [Theory]
    [InlineData(9, new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 })]
    [InlineData(6, new int[] { 3, 2, 4 }, new int[] { 1, 2 })]
    [InlineData(6, new int[] { 3, 3 }, new int[] { 0, 1 })]
    public void TestTwoSum(int target, int[] input, int[] output)
    {
        Assert.Equal(output, Thing.TwoSum(target, input));
    }
}
