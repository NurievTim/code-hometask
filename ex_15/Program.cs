// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введи число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7)
{
    Console.WriteLine("неверное число");
}
else
{
    if (num > 5)
    {
        if (num == 6)
        {
            Console.WriteLine("является выходным (суббота)");
        }
        else Console.WriteLine("является выходным (воскресенье)");
    }
    else
    {
        Console.WriteLine($"{num} - не является выходным");
    }
}

// РЕШЕНИЕ №2

// if (num > 7 && num > -num)
// {
//     Console.WriteLine("неверное число");
// }
// else
// {
//     if (num > 5 && num < 8)
//     {
//         Console.WriteLine("является выходным");
//     }
//     else
//     {
//         Console.WriteLine("не является выходным");
//     }
// }
