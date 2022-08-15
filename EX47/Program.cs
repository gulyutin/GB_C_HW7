// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int  j = 0; j < n; j++)
    {
        array[i, j] = rand.Next();
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("");
}