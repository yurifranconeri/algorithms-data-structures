public class Solution {
    public string LongestCommonPrefix(string[] strs) {       
        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        Array.Sort(strs);
        
        var pointer = 0;
        var result = new StringBuilder();
        while (pointer < strs[0].Length && pointer < strs[strs.Length-1].Length)
        {
            if (strs[0][pointer]==strs[strs.Length-1][pointer])
            {
                result.Append(strs[0][pointer]);
                pointer++;
                continue;
            }
            
            pointer = 201;
        }
        
        return result.ToString();
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {       
        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        var index = 0;
        var result = new StringBuilder();
        var sameLetter = true;
        
        
        while (sameLetter)
        {
            if(index == strs[0].Length)
            {
                break;    
            }
            
            var letter = strs[0][index];
            
            for (int word = 1; word < strs.Length; word++)
            {                
                if (strs[word].Length == index || strs[word][index]!=letter)
                {
                    sameLetter = false;
                    break;
                }
            }
            
            if (!sameLetter)
            {
                break;    
            }
            
            result.Append(letter);   
            index++;
        }
        
        return result.ToString();
    }
}