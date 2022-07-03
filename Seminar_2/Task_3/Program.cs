/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
try{
Console.Write("Введите цифру, обозначающую день недели, и я скажу, является ли этот день выходным: ");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number < 0)
{
    Console.WriteLine("Ваше число не положительное");
}
else if (number > 7)
{
    Console.WriteLine("В неделе только 7 дней");
}
else if (number == 6 | number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}}
catch (System.FormatException)
{
    Console.WriteLine("Ваше число не целое, либо это вовсе не число");
}