//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EventlyNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= array[i] % 2;
         if (array[i] == 0)
         {
            count+=1;
         }
    }
    return count;
}
Console.Clear();
int[] array = CreateArrayRndInt(5,100, 999);
PrintArray(array);
int countNumbers = EventlyNumbers(array);
Console.WriteLine($" -> {countNumbers}");