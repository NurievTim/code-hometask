// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length -1 ; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[7]} ]");
}

FillArray(array);
PrintArray(array);