// Запросите от пользователя размерности двумерного массива
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArithmeticValue(double[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        Console.WriteLine(Math.Round(sum / array.GetLength(1), 2));
        sum = 0;
    }
}

Console.Write("Enter line: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Write column: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[line, column];

FillArray(array);
Console.WriteLine();
ArithmeticValue(array);