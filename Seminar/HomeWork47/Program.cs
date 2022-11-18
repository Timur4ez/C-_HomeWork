// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.

void FillArray(double[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array, m, n);