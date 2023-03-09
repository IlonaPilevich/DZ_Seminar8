// Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента. Массив размером 2*2*2

/// <summary>
/// метод заполняет трёхмерный массив числами от минимального до максимального.
/// </summary>
/// <param name="rows"></param>
/// <param name="cols"></param>
/// <param name="depth"></param>
/// <param name="min"></param>
/// <param name="max"></param>
/// <returns></returns>
int[,,] GetMatrix (int rows, int cols, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int z = 0; z < depth; z++)
            {
                matrix[i, j, z] = new Random().Next(min, max + 1);
            }
        }
    }
    return matrix;
}
/// <summary>
/// метод выводит на печать
/// </summary>
/// <param name="inputMatrix"></param>
void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int z = 0; z < inputMatrix.GetLength(2); z++)
            {
                Console.Write($" {inputMatrix[i, j, z]} ({i}, {j}, {z}); ");
            }
        }
        Console.WriteLine();
    }
}
/// <summary>
/// этот метод выводит массив, добавляя индекс каждого элемента
/// </summary>
/// <param name="array"></param>
/// <param name="element"></param>
/// <returns></returns>
bool IndexElement(int[,,] array, int element)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int depth = array.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int z = 0; z < depth; z++)
            {
                if (array[i, j, z] == element) 
                return true;
            }
        }
    }
    return false;
}
int[,,] resultMatrix = GetMatrix(2, 2, 2, 10, 100);
Console.WriteLine("Массив с указанием индекса элемента: ");
PrintMatrix(resultMatrix);