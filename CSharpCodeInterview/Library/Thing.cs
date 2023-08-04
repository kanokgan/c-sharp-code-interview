namespace Library;

using static Newtonsoft.Json.JsonConvert;

public static class Thing
{
    public static int Get(int left, int right)
    {
        return DeserializeObject<int>($"{left + right}");
    }

    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
    */
    // Time Complexity O(n^2)
    // Space Complexity O(1)
    public static int[] TwoSum(int target, int[] input)
    {
        for (var i = 0; i < input.Length - 1; i++)
        {
            for (var j = i + 1; j < input.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else if (input[i] + input[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { };
    }

    /*
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
    */
    public static bool ValidParentheses(string input)
    {
        var metaData = new Dictionary<Char, Char>()
        {
            { '{', '}' },
            { '[', ']' },
            { '(', ')' },
        };
        var charArray = input.ToCharArray();
        var charStack = new Stack<Char>();
        foreach (var c in charArray)
        {
            if (c == '{' || c == '(' || c == '[')
            {
                charStack.Push(c);
            }
            else if (c == '}' || c == ')' || c == ']')
            {
                if (charStack.Count() > 0 && metaData[charStack.Pop()] == c)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        if (charStack.Count() > 0)
        {
            return false;
        }
        return true;
    }

    /*
        You are given the heads of two sorted linked lists list1 and list2.
        Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
        Return the head of the merged linked list.
    */
    public static List<int> MergeTwoLists(List<int> list1, List<int> list2)
    {
        var sortedList = new List<int>() { };

        if ((list1.Count == 0 && list2.Count == 0) || list1 == null || list2 == null)
            return sortedList;

        while (list1.Count > 0 || list2.Count > 0)
        {
            if (list1.Count == 0)
            {
                var num = list2.First();
                sortedList.Add(num);
                list2.Remove(num);
                continue;
            }

            if (list2.Count == 0)
            {
                var num = list1.First();
                sortedList.Add(num);
                list1.Remove(num);
                continue;
            }

            var l1 = list1.First();
            var l2 = list2.First();
            if (l1 >= l2)
            {
                sortedList.Add(l2);
                list2.Remove(l2);
            }
            else
            {
                sortedList.Add(l1);
                list1.Remove(l1);
            }
        }

        return sortedList;
    }
}
