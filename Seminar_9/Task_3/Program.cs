/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу на экран вычисления функции Аккермана с помощью рекурсии для M и N");

    Console.Write("Вывведите М: ");
    string inputM = Console.ReadLine();
    int m = int.Parse(inputM);

    Console.Write("Вывведите N: ");
    string inputN = Console.ReadLine();
    int n = int.Parse(inputN);

    Console.WriteLine(string.Empty);

    int Akkerman (int n, int m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        else if (n != 0 && m == 0)
        {
            return Akkerman(n - 1, 1);
        }
        else
        {
            return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
    Console.WriteLine(Akkerman(n, m));
    Console.WriteLine(string.Empty);
}

catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}