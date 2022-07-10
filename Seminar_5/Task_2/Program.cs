/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Random rand = new Random();

int inpt = 0;
Console.WriteLine("Показываю сумму чисел, стоящих на нечетных позициях в массиве случайных чисел выбранной длины");
Console.WriteLine("Введите число, обозначающую длинну массива:");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out inpt))
    {
        int[] array = new int[inpt];
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int x = rand.Next(-10, 10);
            array[i] = x;
            Console.Write(array[i] + " ");

            if (i % 2 != 0)
            {
                result = result + array[i];
            }

            if (i == array.Length - 1)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine($"Сумма чисел на нечетной позиции в массиве: {result}");
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