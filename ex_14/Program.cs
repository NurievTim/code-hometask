// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num7 = 7;
int num23 = 23;
if ((num % num7 == 0) && (num % num23 == 0))
{
    Console.Write($"{num} кратно и 7 и 23");
}
else Console.WriteLine("Введите другое число");
