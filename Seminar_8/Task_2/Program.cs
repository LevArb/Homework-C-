/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
int[,] arr = new int[3, 4];

Random rand = new Random();

Console.WriteLine("Суммирую числа в строках матрицы и говорю в какой строке сумма меньше всего");
Console.WriteLine(string.Empty);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i, j] = rand.Next(1, 101);
        Console.Write("{0,4:F0}", arr[i, j]);
    }
    Console.WriteLine(string.Empty);
}
int min = 0;
int y = 400;
for (int i = 0; i < 3; i++)
{
    int x = 0;
    for (int j = 0; j < 4; j++)
    {
        x = x + arr[i, j];
    }
    if (x < y)
    {
        y = x;
        min++;
    }
    Console.Write(" " + x);
    Console.Write(string.Empty);
}
Console.WriteLine(string.Empty);
Console.WriteLine($"Наименьшая сумма в строке {min}");