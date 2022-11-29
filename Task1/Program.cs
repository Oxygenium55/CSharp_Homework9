/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int NaturalNumbers(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumbers(n, m + 1)}, ");
    return m;
}

int n = GetNumber("Введите натуральное число больше нуля: ");
int m = 1;
Console.WriteLine(NaturalNumbers(n, m));
