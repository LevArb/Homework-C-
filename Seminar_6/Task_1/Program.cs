/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int inpt = 0;
int count = 0;
Console.Clear();
Console.WriteLine(string.Empty);
Console.WriteLine("Вводите числа по очереди через 'Enter' и я посчитаю сколько из них больше нуля.");
Console.WriteLine("Введите всё кроме числа для вывода результатов и завершения программы");
while (true)
{
    Console.Write("Введите число:");
    if (int.TryParse(Console.ReadLine(), out inpt))
    {
        if (inpt > 0)
        {
            count++;
        }
    }
    else
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine($"Чисел больше 0 введено: {count}");
        Console.WriteLine(string.Empty);
        break;
    }
}
return inpt;
