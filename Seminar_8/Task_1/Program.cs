/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/
Console.Clear();
int[,] arr = new int[3, 4];

Random rand = new Random();

Console.WriteLine("Сортирую строки в массиве 3х4, попутно выводя массивы на экран");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i, j] = rand.Next(1, 101);
        Console.Write("{0,4:F0}", arr[i, j]);
    }
    Console.WriteLine(string.Empty);
}

Console.WriteLine(string.Empty);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
         {
            if (arr[i, k] > arr[i, k + 1])
            {
                int temp = arr[i, k + 1];
                arr[i, k + 1] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0,4:F0}", arr[i, j]);
    }
    Console.WriteLine(string.Empty);
}