/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу на экран сумму всех натуральных чисел от M до N");

    Console.Write("Вывведите М: ");
    string inputM = Console.ReadLine();
    int m = int.Parse(inputM);

    Console.Write("Вывведите N: ");
    string inputN = Console.ReadLine();
    int n = int.Parse(inputN);

    Console.WriteLine(string.Empty);

    int Summ (int m, int n)
    {   
        if (n > m) 
        {
        return n + Summ(m, n-1);
        }
        return n;
    }
    Console.WriteLine(Summ(m, n));

}

catch(System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}









