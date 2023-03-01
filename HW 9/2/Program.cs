/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers(int number1, int number2)
{
    if (number1 == 0) return (number2 * (number2 + 1)) / 2;                        // number1 = 0
    else if (number2 == 0) return (number1 * (number1 + 1)) / 2;                   // number2 = 0 
    else if (number1 == number2) return number1;                                   // number1 = number2
    else if (number1 < number2) return number2 + SumNumbers(number1, number2 - 1); // number1 < number2
    else return number2 + SumNumbers(number1, number2 + 1);                        // number1 > number2
}


int number1 = Prompt("Введите первое число (левую границу промежутка)");
int number2 = Prompt("Введите второе число (правую границу промежутка)");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} > {SumNumbers(number1, number2)}");