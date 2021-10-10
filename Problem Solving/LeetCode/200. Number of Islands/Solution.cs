using System;

namespace Program
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var grid = new char[][] {
                  new char[]{'1', '1', '0', '0', '0' },
                  new char[]{'1', '1', '0', '0', '0' },
                  new char[]{'0', '0', '1', '0', '0' },
                  new char[]{'0', '0', '0', '1', '1' }
                };
            Console.WriteLine(NumIslands(grid));
        }
        public static int NumIslands(char[][] grid)
        {
            if (grid.Length == 0)
            {
                return 0;
            }

            var islands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islands++;
                        SetIslandToZero(grid, i, j);
                    }
                }
            }

            return islands;
        }

        private static void SetIslandToZero(char[][] grid, int i, int j)
        {
            if (i < 0 || i > grid.Length - 1 || j < 0 || j > grid[i].Length-1 || grid[i][j] == '0')
            {
                return;
            }


            if (grid[i][j] == '1')
            {
                grid[i][j] = '0';
            }

            SetIslandToZero(grid, i-1, j);
            SetIslandToZero(grid, i+1, j);
            SetIslandToZero(grid, i, j+1);
            SetIslandToZero(grid, i, j-1);
        }

    }
}

