/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
try{
Console.Write("Введите трехзначное, положительное, целое число и я выведу вторую цифру этого числа: ");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number < 0)
{
    Console.WriteLine("Ваше число не положительное");
}
else if (number > 999 | number < 100)
{
    Console.WriteLine("Ваше число не трехзначное");
}
else
{
    int result1 = number / 10;
    int result = result1 % 10;
    Console.WriteLine(result);
}}
catch (System.FormatException)
{
    Console.WriteLine("Ваше число не целое, либо это вовсе не число");
}