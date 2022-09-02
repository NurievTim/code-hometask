// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.Write("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

bool square(int a1, int b1)
{
    return (a1 == b1 * b1 || b1 == a1 * a1);
}
bool result = square(a, b);
if (result)
{
    Console.WriteLine("явлется");
}
else Console.WriteLine("не является");