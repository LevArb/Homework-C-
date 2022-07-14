/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
Console.Clear();
Console.WriteLine(string.Empty);
Console.WriteLine("Нахожу точку пересечения двух прямых по заданным вами координатам");

Console.Write("Введите координату k1: ");
string inpt1 = Console.ReadLine();
double k1 = double.Parse(inpt1);

Console.Write("Введите координату k2: ");
string inpt2 = Console.ReadLine();
double k2 = double.Parse(inpt2);

Console.Write("Введите координату b1: ");
string inpt3 = Console.ReadLine();
double b1 = double.Parse(inpt3);

Console.Write("Введите координату b2: ");
string inpt4 = Console.ReadLine();
double b2 = double.Parse(inpt4);

double x = (b2 - b1)/(k1 - k2);

double point1 = k1 * x + b1;
double point2 = k2 * x + b2;

Console.WriteLine(string.Empty);
Console.WriteLine($"Точка пересечения прямых: {point1}; {point2}");
