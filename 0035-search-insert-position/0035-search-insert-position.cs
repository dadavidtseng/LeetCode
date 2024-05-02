public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        if (target < nums[0])
            return 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (target == nums[i])
                return i;

            if (i                  + 1 == nums.Length)
                return nums.Length;
            
            if (target > nums[i] && target < nums[i + 1])
                return i + 1;
        }

        return 0;
    }
}