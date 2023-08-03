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
}
