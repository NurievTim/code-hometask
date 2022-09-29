// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{

}

Console.Write($"min = {number1}; max = {number2} -> ");
NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return;
    if (num2 > num1)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    if (num2 < num1)
    {
        Console.Write($"{num2} ");
        NaturalNumbers(num1, num2 - 1);
    }
}
