// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int index)
{
    int [] result = new int[index];
    for (int i = 0; i < index; i++)
    result[i] = new Random().Next(100, 999);
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  ");
}

int [] array = CreateArray(8);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count = count + 1;
}

Console.WriteLine();
Console.WriteLine("Count of odd numbers: " + count);