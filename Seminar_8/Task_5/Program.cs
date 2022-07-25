/*
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

Random rand = new Random();

Console.Clear();
Console.WriteLine("Cпирально заполняю массив 4 х 4 случайными числами: ");

int m = 4;
int n = 4;

int s = rand.Next(1, 6);

int[,]array = new int[m,n];

for (int y = 0; y < n; y++) 
{
    array[0, y] = s;
    s++;
}
for (int x = 1; x < m; x++) 
{
    array[x, n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--) 
{
    array[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--) 
{
    array[x, 0] = s;
    s++;
}

int c = rand.Next(1, 3);
int d = rand.Next(1, 2);
 
while (s < m * n) 
{
            
    while (array[c, d + 1] == 0) 
    {
        array[c, d] = s;
        s++;
        d++;
    }
 
    while (array[c + 1, d] == 0) 
    {
        array[c, d] = s;
        s++;
        c++;
    }
 
    while (array[c, d - 1] == 0) 
    {
        array[c, d] = s;
        s++;
        d--;
    }
 
    while (array[c - 1, d] == 0) 
    {
        array[c, d] = s;
        s++;
        c--;
    }
}
 
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x, y] == 0) 
        {
            array[x, y] = s;
        }
    }
}
 
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x, y] < 10) 
        {
            //Два пробела, чтобы в консоли столбцы были ровные.
            Console.Write(array[x, y] + ", ");
        } 
        else 
        {
            Console.Write(array[x, y] + ", ");
        }
    }
    Console.WriteLine(string.Empty);
}
