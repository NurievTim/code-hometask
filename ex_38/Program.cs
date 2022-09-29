// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round((array[i]), 1)}, ");
        else Console.Write($"{Math.Round((array[i]), 1)}");
    }
    Console.Write("]");
}

double Max(double[] array)
{
    double max = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min=array[i];
        }
    }
    return min;
}

double[] arr = CreateArrayRndInt(4, 1, 10);
PrintArray(arr);
double maxNum = Max(arr);
double minNum = Min(arr);
double diff = maxNum - minNum;
Console.WriteLine($" -> {Math.Round(diff,1)}");


