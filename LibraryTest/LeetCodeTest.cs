namespace LibraryTest;

using Library;
using Xunit;

public class LeetCodeTest
{
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
        Assert.Equal(output, LeetCode.TwoSum(target, input));
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
        Assert.Equal(expected, LeetCode.ValidParentheses(input));
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
        Assert.Equal(expected, LeetCode.MergeTwoLists(list1.ToList(), list2.ToList()));
    }

    /*
        121. Best Time to Buy and Sell Stock
        You are given an array prices where prices[i] is the price of a given stock on the ith day.
        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    */
    [Theory]
    [InlineData(5, new int[] { 7, 1, 5, 3, 6, 4 })]
    [InlineData(0, new int[] { 7, 6, 4, 3, 1 })]
    public void MaxProfitTest(int expected, int[] inputs)
    {
        Assert.Equal(expected, LeetCode.MaxProfit(inputs));
    }

    /*
    Valid Palindrome
    A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
    it reads the same forward and backward. Alphanumeric characters include letters and numbers.

    Given a string s, return true if it is a palindrome, or false otherwise.
    */
    [Theory]
    [InlineData(true, "A man, a plan, a canal: Panama")]
    [InlineData(false, "race a car")]
    [InlineData(true, " ")]
    public void IsPalindromeTest(bool expected, string input)
    {
        Assert.Equal(expected, LeetCode.IsPalindrome(input));
    }
}