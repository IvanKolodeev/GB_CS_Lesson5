// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int min = array[1];
int max = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)  max = array[i];
    else if (array[i] < min)  min = array[i];
}

Console.WriteLine();
Console.WriteLine($"The difference between max {max} and min {min} is: {max-min}");