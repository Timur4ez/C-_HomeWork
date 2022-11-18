// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}