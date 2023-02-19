/*
Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int [] FillArray(int len)
{
    int [] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1}е число > ");
        array[i] = int.Parse(System.Console.ReadLine());
    }
    return array;
}

int Count(int [] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}

void ShowArray(int [] array)
{
    foreach (int item in array)
    {
        System.Console.WriteLine($"{item}\t");
    }
    System.Console.WriteLine();
}

int num = InputInt("Какое количество чисел хотите ввести? > ");
int []array = FillArray(num);
ShowArray(array);
int count = Count(array);
System.Console.Write($"Чисел больше 0 введено > {count}");
