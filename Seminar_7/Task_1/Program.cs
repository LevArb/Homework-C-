/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу на экран массив из случайных вещественных чисел с заданным вами количеством строк и столбцов");

    Console.Write("Введите число строк: ");
    string inpt1 = Console.ReadLine();
    int m = int.Parse(inpt1);

    Console.Write("Введите число столбцов: ");
    string inpt2 = Console.ReadLine();
    int n = int.Parse(inpt2);

    Console.WriteLine(string.Empty);

    double[,] arr = new double[m, n];

    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int x = rand.Next(-1, 1);
            if (x == 0)
            {
                x = 1;
            }
            arr[i, j] = rand.NextDouble() * 100 * x;
            Console.Write("{0,6:F1}", arr[i, j]);
        }
        Console.WriteLine(string.Empty);
    }
    Console.WriteLine(string.Empty);
}
catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}
