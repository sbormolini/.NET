namespace Exercism;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[] rowMaxs = Enumerable.Range(0, rows)
                                  .Select(row => Enumerable.Range(0, cols)
                                  .Max(col => matrix[row, col]))
                                  .ToArray();
        
        int[] colMins = Enumerable.Range(0, cols)
                                  .Select(col => Enumerable.Range(0, rows)
                                  .Min(row => matrix[row, col]))
                                  .ToArray();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (rowMaxs[row] == colMins[col])
                    yield return (row + 1, col + 1);
            }
        }
    }
}