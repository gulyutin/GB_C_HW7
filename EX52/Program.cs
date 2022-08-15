// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m, n];

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

Console.WriteLine();
Console.WriteLine($"Cреднее арифметическое: ");
for (int i = 0; i < n; i++)
{
  double ave = 0;
  for (int j = 0; j < m; j++)
  {
    ave += array[j, i];
  }
  ave = ave / m;
  Console.Write($"{ave}\t");
}

