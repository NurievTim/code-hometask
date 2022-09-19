// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int ca = Convert.ToInt32(Console.ReadLine());

if (ab < (bc + ca) && bc < (ab + ca) && ca < (ab + bc))
{
    Console.WriteLine("такой треугольник существует");
}
else Console.WriteLine("такой треугольник не существует");