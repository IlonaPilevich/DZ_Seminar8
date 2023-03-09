// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/// <summary>
/// метод заполняет двумерный массив числами от минимального до максимального.
/// </summary>
/// <param name="rows"></param>
/// <param name="cols"></param>
/// <param name="min"></param>
/// <param name="max"></param>
/// <returns></returns>
int[,] GetMatrix (int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>
/// метод печатает матрицу, которую передали на вход.
/// </summary>
/// <param name="inputMatrix"></param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] firstMatrix = GetMatrix(2, 2, 1, 10);
Console.WriteLine("Первая матрица: "); 
PrintMatrix(firstMatrix);
int[,] secondMatrix = GetMatrix(2, 2, 1, 10);
Console.WriteLine("Вторая матрица:");  
PrintMatrix(secondMatrix);
/// <summary>
/// метод находит произведение двух матриц (по формуле нахождения произведения матриц А и В), необходимо три цикла for
/// </summary>
/// <param name="firstMatrix"></param> // первая матрица
/// <param name="secondMatrix"></param> // вторая матрица
/// <returns></returns>
int[,] DoubleMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int rowsFirst = firstMatrix.GetLength(0);
    int colsFirst = firstMatrix.GetLength(1);
    int rowsSecond = secondMatrix.GetLength(0);
    int colsSecond = secondMatrix.GetLength(1);
    int[,] MultiMatrix = new int[rowsFirst, colsSecond];
    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < colsSecond; j++)
        {
            for (int z = 0; z < colsFirst; z++) 
            {  
                MultiMatrix[i, j] = (firstMatrix[i, z] * secondMatrix[z, j]) + MultiMatrix[i, j];
            }
        }
    }
    return MultiMatrix;
}
int[,] MultiMatrix = DoubleMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц равно: ");
PrintMatrix(MultiMatrix);
