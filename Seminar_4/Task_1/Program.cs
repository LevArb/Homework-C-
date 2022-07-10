/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243
2, 4 -> 16
*/
try
{
    Console.Clear();
    Console.WriteLine("Цикл, возводящий в степень, вместо Pow()");

    Console.Write("Введите число: ");
    string inputX = Console.ReadLine();
    int x = int.Parse(inputX);

    Console.Write("Введите число степени возведения: ");
    string inputY = Console.ReadLine();
    int y = int.Parse(inputY);

    int fX = x;
    for (int i = 1; i < y; i++)
    {
        x = x * fX;
    }
    Console.WriteLine($"Ответ: {x}");
}
catch (System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
    
}