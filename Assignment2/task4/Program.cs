int[][] matrix = new int[][]
{
    new int[] { 1, 2, 3, 4},
    new int[] { 5, 1, 2, 3},
    new int[] { 9, 5, 1, 2},
};

int sizeOfRow =  matrix.Length;
int sizeOfCol = matrix[0].Length;

bool isRight = true;
for (int i = 0; i < sizeOfRow; i++)
{
    for (int j = 0; j < sizeOfCol; j++)
    {
        int nextRow = i + 1;
        int nextCol = j + 1;
        if (nextRow == sizeOfRow) continue;
        if (nextCol == sizeOfCol) continue;
        if (matrix[i][j] != matrix[nextRow][nextCol]) { isRight = false; break; }
    }
}

Console.WriteLine(isRight);