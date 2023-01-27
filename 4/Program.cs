/* 
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите любое натуральное число > ");
String number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
int index = 1;
while (index <= a)
{
    if (index % 2 == 0)
    {
        System.Console.Write($"{index} ");
    }
    index++;
}