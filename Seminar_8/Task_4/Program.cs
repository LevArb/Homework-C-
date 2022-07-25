/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/
Console.Clear();
int[,,] arr = new int[2, 2, 2];

Random rand = new Random();

Console.WriteLine("Вывожу построчно трехмерный массив с индексами");
Console.WriteLine(string.Empty);


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            arr[i, j, k] = rand.Next(10, 100);
            Console.Write("{0,4:F0}", arr[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
        }
        Console.WriteLine(string.Empty);
    }
}
Console.WriteLine(string.Empty);