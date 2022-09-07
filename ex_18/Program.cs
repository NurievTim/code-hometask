// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string Quarter(string quarter1)
{
    if (quarter1 == "1") return "x>0, y>0";
    if (quarter1 == "2") return "x<0, y>0";
    if (quarter1 == "3") return "x<0, y<0";
    if (quarter1 == "4") return "x>0, y<0";
    return "Введено неправильное число";
}
string result = Quarter(quarter);
Console.WriteLine(result);

