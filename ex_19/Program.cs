// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено неправильное число");
}
else
{
int firstDigit = num / 10000;
int secondDigit = (num / 1000) % 10;
int fourthDigit = (num % 100) / 10;
int fifthDigit = num % 10;

if (firstDigit == fifthDigit || secondDigit == fourthDigit)
{
    Console.WriteLine($"число {num} - является полиндромом");
}
else Console.WriteLine($"число {num} - не является полиндромом");
}