// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая запишет нулями строку и столбец, на пересечении которых расположен наименьший элемент массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывести двумерный массив в консоль в виде матрицы.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{
    int min = array[0, 0];
    int minRow = 0; 
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[minRow, j] = 0;
            array[i, minCol] = 0;
        }
    }
}

Console.Write("Enter Line: ");
int Line = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Column: ");
int Column = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[Line, Column];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
ChangeArray(arr);
PrintArray(arr);