public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        var j = 0;

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != val)
                nums[j++] = nums[i];

        return j;
    }
}