/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Проверка пятизначного числа (полиндром или нет). Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int num1 = number % 10;
int num2 = (number / 10) % 10;
int num4 = (number / 1000) % 10;
int num5 = (number / 10000) % 10;

if (num1 == num5 & num2 == num4)
{
    Console.Clear();
    Console.WriteLine("Да, это число - полиндром.");
    Console.WriteLine(string.Empty);
}
else
{
    Console.Clear();
    Console.WriteLine("Нет, это число не полиндром.");
    Console.WriteLine(string.Empty);
}