/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int x = 8;
int[] CreateArray(int x)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

void Printarray(int[] array)
{
    for (int j = 0; j < array.Length - (x - 1); j++)
    {
        //System.Console.Write($"{array[j]} ");
        Console.WriteLine("[{0}]", string.Join(", ", array));
    }
}

int [] array = CreateArray(8);
Printarray(array);
