/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int digit)
{
    int[] array = new int[digit];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} \t");
    }
    System.Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
    }


int digit = Prompt("Введите число");
int[] array = GenerateArray(digit);
PrintArray(array);
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна > {Count(array)}");