/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа и я найду из них максимальное");
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} больше чем {number1}");
}
else
{
    Console.WriteLine("Эти числа равны!");
}

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("Введите 3 числа и я выведу максимальное");
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.Write("Введите третье число: ");
string input3 = Console.ReadLine();
int number3 = int.Parse(input3);
int max = number1;
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (max > number3)
{
    Console.WriteLine($"Наибольшее число: {max}");
}
else
{
    Console.WriteLine($"Наибольшее число: {number3}");
}

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите число числа и я скажу, четное оно или нет");
Console.Write("Введите число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
if (number1 % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine("Введите число, и я выведу все числа от 1 до этого числа");
Console.Write("Введите число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
int count = 2;
Console.Write("1");
while (count <= number1)
{
    Console.Write(" " + count);
    count += 2;
}
*/