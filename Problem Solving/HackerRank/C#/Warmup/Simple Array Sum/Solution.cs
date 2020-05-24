using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    static int SimpleArraySum(int[] ar) {
        List<int> arrayList = new List<int>(ar);
        return arrayList.Sum();
    }

    static void Main(string[] args) {
        int arCount = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(
                Console.ReadLine().Split(' '), 
                arTemp => Convert.ToInt32(arTemp)
            );
        
        int result = SimpleArraySum(ar);

        Console.WriteLine(result);
    }
}
