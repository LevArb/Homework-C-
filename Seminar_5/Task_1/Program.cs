/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Random rand = new Random();

int inpt = 0;
Console.WriteLine("Показываю количество случайных, чётных, трехзначных чисел в массиве выбранной длины");
Console.WriteLine("Введите число, обозначающую длинну массива:");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out inpt))
    {
        int[] array = new int[inpt];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int x = rand.Next(100, 999);
            array[i] = x;
            Console.Write(array[i] + " ");

            if (array[i] % 2 == 0)
            {
                count++;
            }

            if (i == array.Length - 1)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine($"Четных чисел в массиве: {count}");
            }
        }
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы ввели не число, введите корректные данные");
    }
}
return inpt;