namespace LeetCode._01_TwoSum;

public static class Program_TwoSum {
    public static void Main()
    {
        var targetArray = TwoSum([2,7,11,15], 9);

        foreach (var target in targetArray)
        { 
            Console.WriteLine(target);
        }
    }

    private static int[] TwoSum(int[] nums, int target) 
    {
        var numIndices = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (numIndices.TryGetValue(complement, out var index))
            {
                return [index, i];
            }

            // Add the current number and its index to the dictionary
            numIndices.TryAdd(nums[i], i);
        }

        // No solution found
        throw new ArgumentException("No two elements add up to the target.");
    }
}