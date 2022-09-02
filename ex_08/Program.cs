// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int count = 2;
Console.WriteLine($"Четные числа от 1 до {num} : ");

while (count < num)
{
    Console.Write($"{count} ");
    count = count + 2;
}
Console.WriteLine();