/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу на экран все натуральные числа от M до N (или от N до M)");

    Console.Write("Вывведите М: ");
    string inputM = Console.ReadLine();
    int m = int.Parse(inputM);

    Console.Write("Вывведите N: ");
    string inputN = Console.ReadLine();
    int n = int.Parse(inputN);

    Console.WriteLine(string.Empty);

    while (m <= n)
    {
        Console.Write($"{m} ");
        m++;
    }
    while (n <= m)
    {
        Console.Write($"{n} ");
        n++;
    }

}

catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}