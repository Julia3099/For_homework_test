/*
Задача 2. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 1 -> 1
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
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

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}

bool ValidatePosition(int[,] array, int x, int y)
{
    if (x > array.GetLength(0) || y > array.GetLength(1))
    {
        System.Console.WriteLine("Элемента с такой позицией нет. Попробуйте ещё раз.");
        return false;
    }
    return true;
}

int PositionOfElement(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x -1 && j == y - 1) return array[i, j];
        }
    }
    return array[x, y];
}

int[,] matrix = new int [5, 5];
FillArray(matrix);
PrintArray(matrix);
int firstPosition = Prompt("Введите номер строки элемента ");
int secondPosition = Prompt("Введите номер столбца элемента ");
if (ValidatePosition(matrix, firstPosition, secondPosition))
{
    int pos = PositionOfElement(matrix, firstPosition, secondPosition);
    System.Console.WriteLine($"На данной позиции находится элемент > {pos}");
}