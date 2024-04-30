public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        var numsList = new List<int>();

        foreach (var num in nums)
        {
            if (!numsList.Contains(num))
                numsList.Add(num);
        }

        Array.Clear(nums);
        var numsArray = numsList.ToArray();

        for (var i = 0; i < nums.Length; i++)
        {
            if (i >= numsList.Count)
                continue;

            nums[i] = numsArray[i];
        }

        return numsList.Count;
    }
}