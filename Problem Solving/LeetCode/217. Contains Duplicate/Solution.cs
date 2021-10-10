public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        var hash = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hash.Contains(num))
            {
                return true;
            }

            hash.Add(num);
        }
        
        return false;
    }
}