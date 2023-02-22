/*
Задача 1: Задайте двумерный массив. Напишите программу, 
которая упорядочивает по убыванию элементы каждой строки двумерного массива.
*/

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); ;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sort(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
                if (matrix[rows, j] > matrix[rows, j - 1])
                {
                    int temp = matrix[rows, j];
                    matrix[rows, j] = matrix[rows, j - 1];
                    matrix[rows, j - 1] = temp;
                }
    return matrix;
}

int[,] array = CreateMatrix(3, 3);
PrintMatrix(array);
Sort(array);
System.Console.WriteLine();
PrintMatrix(array);
