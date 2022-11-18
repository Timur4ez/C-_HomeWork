// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = i + j;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

void FillArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array, m, n);
