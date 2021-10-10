public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var start = 0;
        var end = numbers.Length-1;
        
        while (start < end) {
            if (numbers[start] + numbers[end] == target){
                break;
            }
            
            if (numbers[start] + numbers[end] < target){
                start++;
                continue;
            }
            
            end--;
        }
        
        return new int[] {++start, ++end};
    }
}