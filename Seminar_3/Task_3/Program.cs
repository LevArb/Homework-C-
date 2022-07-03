/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("принимаю на вход число и выдаю таблицу кубов чисел от 1 до N");
try
{
    Console.Write("Введите число: ");
    string input1 = Console.ReadLine();
    double number = double.Parse(input1);
    double count = 0;
    double x = 1;
    while (count < number)
    {
        Console.WriteLine(Math.Pow(x, 3));
        count++;
        x++;
    }
}
catch (System.FormatException)
{
    Console.WriteLine("Введите корректный формат данных");
}