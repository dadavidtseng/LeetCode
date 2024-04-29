public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var difference = target - nums[i];

            if (numDictionary.TryGetValue(difference, out var index))
                return [index, i];

            numDictionary.TryAdd(nums[i], i);
        }

        throw new ArgumentException("No two elements add up to the target.");
    }
}