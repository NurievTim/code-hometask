// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int Result(int num)
{
    if (num != 0)
    {
        int sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        return sum;
    }
    else return 1;
}

int res = Result(number);

Console.WriteLine($"{number}! = {res}");