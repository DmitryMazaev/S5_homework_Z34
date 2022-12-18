/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
}
int[] array = GetArray(4, 100, 1000);
PrintArray(array);

int even = 0;
foreach (int el in array)
{
    if (el%2 == 0)
    {
        even++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {even}");