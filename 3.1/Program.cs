/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCompliance(int Prompt)
{
    if (Prompt > 9999 && Prompt < 100000)
    {
        return true;
    }
    System.Console.WriteLine("Мы договаривались: пятизначное число! Попробуйте ещё раз!");
    return false;
}

int FirstNum;
int SecondNum;
int ThirdNum;
int FourthNum;
int LastNum;

int digit = Prompt("Введите пятизначное число");

FirstNum = digit / 10000;
SecondNum = (digit / 1000) % 10;
FourthNum = (digit % 100) / 10;
LastNum = digit % 10;

if (ValidateCompliance(digit))
{
    if (FirstNum == LastNum && SecondNum == FourthNum)
    {
        System.Console.WriteLine($"Да, число {digit} является палиндромом.");
    }
    else System.Console.WriteLine($"Нет, число {digit} палиндромом не является.");
}

