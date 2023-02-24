// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int index)
{
    int [] result = new int[index];
    for (int i = 0; i < index; i++)
    result[i] = new Random().Next(-99, 99);
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  ");
}

int [] array = CreateArray(5);
PrintArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((i+1) %2 != 0)    sum = sum + array[i];
}

Console.WriteLine();
Console.WriteLine("Sum of elements with even index is: " + sum);