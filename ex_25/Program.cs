// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int aa, int bb)
{
    int result = 1;
    for (int i = 0; i < bb; i++)
    {
        result = result * aa;
    }
    return result;
}
int res = Degree(a, b);
Console.WriteLine($"{a}, {b} -> {res}");