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
    public void TestTwoSumTest(int target, int[] input, int[] output)
    {
        Assert.Equal(output, Thing.TwoSum(target, input));
    }

    /*
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
    */
    [Theory]
    [InlineData(true, "()")]
    [InlineData(true, "()[]{}")]
    [InlineData(false, "(]")]
    [InlineData(false, "[")]
    [InlineData(false, "]")]
    public void ValidParenthesesTest(bool expected, string input)
    {
        Assert.Equal(expected, Thing.ValidParentheses(input));
    }

    /*
        You are given the heads of two sorted linked lists list1 and list2.
        Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
        Return the head of the merged linked list.
    */
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 3, 4, 4 }, new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { 0 }, new int[] { }, new int[] { 0 })]
    public void MergeTwoListsTest(
        IEnumerable<int> expected,
        IEnumerable<int> list1,
        IEnumerable<int> list2
    )
    {
        Assert.Equal(expected, Thing.MergeTwoLists(list1.ToList(), list2.ToList()));
    }
}
