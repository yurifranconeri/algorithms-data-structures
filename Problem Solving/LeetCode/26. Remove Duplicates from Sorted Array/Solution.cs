public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) {
            return nums.Length;
        }
        
        var pointer = 0;
        var index = 1;
        
        while (pointer < nums.Length && index < nums.Length )
        {   
            if (nums[pointer] != nums[index])
            {
                nums[pointer+1]=nums[index];
                pointer++;
                index++;
                continue;
            }
            
            while (index < nums.Length && nums[pointer] == nums[index])
            {
                index++;    
            }
        }
        
        return pointer+1;
    }
}