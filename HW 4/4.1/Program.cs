/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int degree;
int num1 = Prompt("Введите число, которое хотите возвести в степень");
int num2 = Prompt("Введите степень, в которую хотите возвести выбранное число");

int Degree(int num1, int num2)
{
    degree = 1;
    for (int i = 0; i < num2; i++)
    {
        degree *= num1;
    }
    return degree;
}

System.Console.WriteLine($"Число {num1} в степени {num2} равно {Degree(num1, num2)}");
