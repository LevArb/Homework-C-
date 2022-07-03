/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

try{
Console.Write("Введите положительное, целое число и я выведу третью цифру этого числа, и скажу если её нет: ");
string input = Console.ReadLine();
int zerocount = input.Length;
int count = 0;
int zeroes = 1;
if (zerocount >= 4)
{
    while (count < (zerocount - 3))
    {
        zeroes = zeroes*10;
        count++;
    }
}
int number = int.Parse(input);
if (number < 0)
{
    Console.WriteLine("Ваше число не положительное");
}
else if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int result1 = number / zeroes;
    int result = result1 % 10;
    Console.WriteLine(result);
}}
catch (System.FormatException)
{
    Console.WriteLine("Ваше число не целое, либо это вовсе не число");
}