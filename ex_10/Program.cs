// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введи трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100 && num < 1000)
{
    int num2 = num / 10;
    int secondDigit = num2 % 10;
    Console.WriteLine($"{secondDigit}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}