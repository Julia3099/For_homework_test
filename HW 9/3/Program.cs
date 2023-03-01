/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AkkermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkermanFunction (m - 1, 1);
  else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

System.Console.WriteLine($"Функция Аккермана имеет вид A(m, n) = ...");
int m = Prompt("Введите m");
int n = Prompt("Введите n");
System.Console.WriteLine($"Функция Аккермана при заданных значениях принимает вид > A({m}, {n}) = {AkkermanFunction(m, n)}");