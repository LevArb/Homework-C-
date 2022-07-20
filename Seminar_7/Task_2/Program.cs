/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
int[,] arr = new int[5, 5];

Random rand = new Random();

Console.WriteLine("Ищу выбранное вами значение в массиве 5х5, попутно выводя массив на экран");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = rand.Next(1, 101);
        Console.Write("{0,6:F0}", arr[i, j]);
    }
    Console.WriteLine(string.Empty);
}
int check = 1;
try
{
    Console.Write("Введите число: ");
    string inpt1 = Console.ReadLine();
    int x = int.Parse(inpt1);
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (arr[i, j] == x)
            {
                Console.WriteLine("Это число есть в массиве");
                check = 2;
            }
        }
    }
if (check == 1)
{
    Console.WriteLine("Такого числа в массиве нет");
}
}
catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}
