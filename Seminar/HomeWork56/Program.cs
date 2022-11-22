// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchArray(int[,] array)
{
    int indexLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой елементов под номером: {indexLine}"); 
    Console.WriteLine($"Сумма элементов строки: {minsum}");
}


int size = new Random().Next(1, 10);

int[,] array = new int[size, size];

FillArray(array);
Console.WriteLine();
SearchArray(array);
