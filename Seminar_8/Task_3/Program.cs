/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
Console.Clear();
int[,] arr1 = new int[3, 4];
int[,] arr2 = new int[3, 4];

Random rand = new Random();

Console.WriteLine("Суммирую числа в 2-х массивах и вывожу на экран");
Console.WriteLine(string.Empty);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr1[i, j] = rand.Next(1, 21);
        Console.Write("{0,4:F0}", arr1[i, j]);
    }
    Console.WriteLine(string.Empty);
}

Console.WriteLine(string.Empty);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr2[i, j] = rand.Next(1, 21);
        Console.Write("{0,4:F0}", arr2[i, j]);
    }
    Console.WriteLine(string.Empty);
}

Console.WriteLine(string.Empty);
Console.WriteLine("Произведение двух массивов:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        int x = 0;
        x = arr1[i, j] * arr2[i, j];
        Console.Write("{0,4:F0}", x);
    }
    Console.WriteLine(string.Empty);
}