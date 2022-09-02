//  9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int number = new Random().Next(10, 100);
// int FirstDigit = number / 10;
// int SecondDigit = number % 10;

// if (FirstDigit>SecondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {FirstDigit} ");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {FirstDigit} ");

// int max = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} -> {FirstDigit} ");

int MaxDigit(int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit} ");