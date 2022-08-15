// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
double [,] array = new double[m, n];

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

Console.Write("Введите номер строкм массива: ");
int positionY = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца массива: ");
int positionX = int.Parse(Console.ReadLine());

if(positionY <= m && positionX <= n  && positionY >= 0  && positionX >= 0) 
{
  double result = array[positionY-1, positionX-1];
  Console.Write($"Значение элемента массива: {result}\t");
}
else Console.Write($"Такого элемента в массиве нет\t");