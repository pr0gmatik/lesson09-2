// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите положительное число");
int a = Convert.ToInt32(Console.ReadLine());


int b = 1;
if (a < 1)
{
    Console.WriteLine("Вы ввели не положительное число");
}
Console.WriteLine(Recurs(a, b));

int Recurs(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{Recurs(a, b + 1)}, ");
    return b;
}