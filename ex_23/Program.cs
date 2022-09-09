// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// int degree = 3;

// while (count <= n)
// {
//     Console.WriteLine($"{count} -> {Math.Pow(count, degree)} ");
//     count++;
// }

Console.Write($"{n} -> ");
for (int i = 1; i <= n - 1; i++)
{
    Console.Write($"{i * i * i}, ");
}
Console.WriteLine($"{n * n * n}");