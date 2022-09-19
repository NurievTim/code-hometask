// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    if (num != 0)
    {
        int tempNum = default;
        while (num > 1)
        {
            tempNum = tempNum + (num % 10);
            num = num / 10;
        }
        return tempNum+1;
       
    }
    return 0;
}
int sum = SumDigits(number);
Console.WriteLine($"{number} -> {sum}");
