public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        if (nums.Length == 0)
            return 0;

        var j = 0;

        for (var i = 1; i < nums.Length; i++)
            if (nums[j] != nums[i])
                nums[++j] = nums[i];

        return j + 1;
    }
}