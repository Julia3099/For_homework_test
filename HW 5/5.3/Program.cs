/*
Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = Math.Round(rnd.NextDouble() * (1000 - 1), 1);
        array[i] = num;
    }
    return array;
}

void Printarray(double[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} \t");
    }
    System.Console.WriteLine();
}

double Max(double []array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        
    }
    return max;
}

double Min(double []array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        
    }
    return min;
}

int digit = Prompt("Введите число");
double[] array = GenerateArray(digit);
double max = Max(array);
double min = Min(array);
Printarray(array);
System.Console.WriteLine($"Разница между максимальным {max} и минимальным {min} составляет > {Math.Round(max - min, 2)}");