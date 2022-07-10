/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
try
{
Console.Clear();
Console.WriteLine("Суммирую все числа введенного числа и вывожу ответ");
Console.Write("Ведите число: ");
string input = Console.ReadLine();
long x = long.Parse(input);
long ten = 10;
long y = 1;
long i = 1;
long answer = 0;

while (i <= input.Length)
{
    answer = answer + (x / y) % 10;
    i++;
    y = y * ten;
}

Console.WriteLine($"Сумма цифр вашего числа: {answer}");
}
catch (System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректное данные");
}