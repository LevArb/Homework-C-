﻿/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
try
{
    Console.Clear();
    Console.WriteLine("Вывожу на экран массив из 8 случайных чисел, в диапазоне от 1 до заданного числа");
    Console.Write("Ведите число: ");
    string input = Console.ReadLine();
    int x = int.Parse(input);

    int[] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, x);
    }
    
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[7]}]");
}
catch (System.FormatException)
{
    Console.Clear();
    Console.WriteLine("Вы ввели не число, введите корректные данные");
}