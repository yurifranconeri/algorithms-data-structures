using System;
using System.Collections.Generic;
using System.Linq;
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
                new int[] { 1, 0, 3, 4 },
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

        //Write an algorithm such that if an element in an MxN matrix is 0, its entire row and 
        //column is set to 0
        public static int[][] SetZeros(int[][] matrix)
        {
            //track column with 0
            var columnsWithZero = new bool[matrix[0].Length];
            //track row with 0
            var rowsWithZero = new bool[matrix.Length];

            //store rows/columns with 0
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowsWithZero[i] = true;
                        columnsWithZero[j] = true;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rowsWithZero[i] || columnsWithZero[j])
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
