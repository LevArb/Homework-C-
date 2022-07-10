/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Random rand = new Random();

int inpt = 0;
Console.WriteLine("Показываю разницу между макс и мин числами, в массиве случайных чисел выбранной длины");
Console.WriteLine("Введите число, обозначающую длинну массива:");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out inpt))
    {
        int[] array = new int[inpt];
        int max = array[0];
        int min = int.MaxValue;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            int x = rand.Next(1, 101);
            array[i] = x;
            Console.Write(array[i] + " ");

            if (max <= array[i])
            {
                max = array[i];
            }
            else
            {
                max = max;
            }
            
            if (min >= array[i])
            {
                min = array[i];
            }
            else
            {
                min = min;
            }

            if (i == array.Length - 1)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");
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