// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/// <summary>
/// метод заполняет двумерный массив числами от минимального до максимального.
/// </summary>
/// <param name="rows"></param>
/// <param name="cols"></param>
/// <param name="min"></param>
/// <param name="max"></param>
/// <returns></returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
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
int[,] resultMatrix = GetMatrix(3, 4, 0, 5);
Console.WriteLine("Исходный массив: ");
PrintMatrix(resultMatrix);
/// <summary>
/// метод вывода номера строки с наименьшей суммой элементов.
/// </summary>
/// <param name="array"></param>
int ValueRowSumMin(int[,] array)
{
    int RowsMin = int.MaxValue; // взяли max для поиска min
    int SumRows = int.MinValue; // взяли min для поиска max
    int SumRowsMin = int.MaxValue; //минимальная сумма строк
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        SumRows = 0;
        for (int j = 0; j < cols; j++)
        {
            SumRows += array[i, j];
        }
         if (SumRows < RowsMin)
        {
            RowsMin = SumRows;
            SumRowsMin = i;
        }
    }
    return SumRowsMin;
}
int SumRowsMin = ValueRowSumMin(resultMatrix);
Console.Write($"Строка с наименьшей суммой элементов: {SumRowsMin + 1}");
