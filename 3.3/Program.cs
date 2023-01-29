/* 
Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int chislo = Prompt("Введите число N");

System.Console.WriteLine($"Кубы чисел от 1 до {chislo}: ");

for (int index = 1; index < chislo + 1; index++)
{
    System.Console.WriteLine($"{Math.Pow(index, 3)} ");
}