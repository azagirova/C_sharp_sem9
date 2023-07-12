/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void PrintNumbers(int start, int end)
{
    if (start > end) return;
    PrintNumbers(start + 1, end);
    Console.Write(start + " ");
}

int n = InputNum("Введите любое целое число: ");
PrintNumbers(1, n);



/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
void PrintNumbers(int m, int n)
{
    if (m > n) return;
    Console.Write(m + " ");
    PrintNumbers(m + 1, n);
}

int SumDigits(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumDigits(m, n);
        return res;
    }
}
void SumFromMToN(int m, int n)
{
    Console.WriteLine(SumDigits(m - 1, n));
}

int m = InputNum("Введите любое целое число: ");
int n = InputNum("Введите любое целое число: ");

PrintNumbers(m, n);
Console.WriteLine();
SumFromMToN(m, n);


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = InputNum("Введите любое целое число: ");
int n = InputNum("Введите любое целое число: ");


int res = Ackermann(m, n);
Console.WriteLine(res);