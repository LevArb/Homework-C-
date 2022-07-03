/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
try
{
    Console.Clear();
    Console.WriteLine("Введите координаты 2-х точек и я покажу расстояние между ними");

    Console.WriteLine("Введите координаты 1-й точки");
    Console.Write(" x1: ");
    string inputx1 = Console.ReadLine();
    double x1 = double.Parse(inputx1);

    Console.Write(" y1: ");
    string inputy1 = Console.ReadLine();
    double y1 = double.Parse(inputy1);

    Console.Write(" z1: ");
    string inputz1 = Console.ReadLine();
    double z1 = double.Parse(inputz1);

    Console.WriteLine("Введите координаты 2-й точки");
    Console.Write(" x2: ");
    string inputx2 = Console.ReadLine();
    double x2 = double.Parse(inputx2);

    Console.Write(" y2: ");
    string inputy2 = Console.ReadLine();
    double y2 = double.Parse(inputy2);

    Console.Write(" z2: ");
    string inputz2 = Console.ReadLine();
    double z2 = double.Parse(inputz2);

    double answer = Math.Sqrt(Math.Pow((x2 - x1), 2)
    + Math.Pow((y2 - y1), 2)
    + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Рассточние между точками: {answer}");
}
catch (System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Введен некорректный формат данных");
}