
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            var matrix = new int[][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 }
            };
            
            var result = SetZeros(matrix);

            StringBuilder sb = new StringBuilder();
            foreach (var row in result)
            {
                sb.Append('[');
                sb.Append($"{string.Join(',', row)}");
                sb.Append(']');
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }

        public static int[][] Rotate(int[][] matrix){
            //TODO
            return matrix;
        }

        
    }
}
