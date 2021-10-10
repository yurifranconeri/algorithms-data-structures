public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var triagle = new List<IList<int>>();
        var firstRow = new List<int>();
        firstRow.Add(1);
        triagle.Add(firstRow);

        for (int i = 1; i < numRows; i++)
        {
            var prevRow = triagle[i - 1];
            var newRow = new List<int>();
            newRow.Add(1);

            for (int j = 0; j < prevRow.Count - 1; j++)
            {
                newRow.Add(prevRow[j] + prevRow[j+1]); 
            }

            newRow.Add(1);
            triagle.Add(newRow);
        }

        return triagle;
    }
}