public class Solution {
    public bool IsPalindrome(int x) {
        var numberText = x.ToString();

        var start = 0;
        var end = numberText.Length-1;

        while (start < end)
        {
            if (numberText[start] != numberText[end])
            {
                return false;
            }

            start++;
            end--;
        }


        return true;
    }
}