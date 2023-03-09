// Задайте двумерный массив. НАпишите программу, которая упорядочит по убыванию элемпенты каждой строки двумерного массива.

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
/// метод печатает матрицу, которая передали на вход.
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
int[,] resultMatrix = GetMatrix(4, 4, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(resultMatrix);
/// <summary>
/// метод упорядочит по убыванию элементы в каждой строке массива.
/// </summary>
/// <param name="inputMatrix"></param>
/// <returns></returns>
int[,] DecreasingArray(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int cols = inputMatrix.GetLength(1);
    int temp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int l = j + 1; l < cols; l++)
            {
                if (inputMatrix[i, j] > inputMatrix[i, l])
                {
                    temp = inputMatrix[i, j];
                    inputMatrix[i, j] = inputMatrix[i, l];
                    inputMatrix[i, l] = temp;
                }
                else 
                {
                   if (inputMatrix[i, j] < inputMatrix[i, l])
                {
                    temp = inputMatrix[i, j];
                    inputMatrix[i, j] = inputMatrix[i, l];
                    inputMatrix[i, l] = temp;
                } 
                }
            }
        
        }
    }
    return inputMatrix;
}
int[,] sortArray = DecreasingArray(resultMatrix);
Console.WriteLine("\nОтсортированный массив по убыванию: ");
PrintMatrix(sortArray);