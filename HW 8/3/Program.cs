/*
Задача 3: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5); ;
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

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int [,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
            result[i, j] = result[i, j];
        }
        return result;
    
}

int [,] array1 = CreateMatrix(3, 4);
int [,] array2 = CreateMatrix(4, 4);
int [,] result = Multiplication(array1, array2);

System.Console.WriteLine("Матрица 1 > ");
PrintMatrix(array1);
System.Console.WriteLine();
System.Console.WriteLine("Матрица 2 > ");
PrintMatrix(array2);
System.Console.WriteLine();
System.Console.WriteLine("После перемножения получаем > ");
PrintMatrix(result);