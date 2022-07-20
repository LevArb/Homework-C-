/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу среднее арифметическое чисел в столбцах массива заданного вами размера");

    Console.Write("Введите число строк: ");
    string inpt1 = Console.ReadLine();
    int m = int.Parse(inpt1);

    Console.Write("Введите число столбцов: ");
    string inpt2 = Console.ReadLine();
    int n = int.Parse(inpt2);

    Console.WriteLine(string.Empty);

    double[,] arr = new double[m, n];

    Random rand = new Random();
    double x = 0.0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.NextDouble() * 100;
            Console.Write("{0,6:F0}", arr[i, j]);
        }
        Console.WriteLine(string.Empty);
    }
    Console.WriteLine(string.Empty);

    for (int i = 0; i < n; i++)
    {
        x = 0.0;
        for (int j = 0; j < m; j++)
        {
            x = x + arr[j, i]; 
        }
        Console.Write("{0,6:F1}", x / n);
    }
}
catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}