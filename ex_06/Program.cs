// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//           является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 2;

if (num2 == 0)
{
    Console.WriteLine($"{num} - четное число");
}
else 
{
Console.WriteLine("Введено неправильное число");
}