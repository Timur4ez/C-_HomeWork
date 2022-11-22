// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillArray(int[,] array)
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0)
            {
            int temp = array[i, j];
            array[i, j] = array[array.GetLength(0) -1, j];
            array[array.GetLength(0) -1, j] = temp;
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter Line: ");
int Line = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Column: ");
int Column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[Line, Column];

FillArray(array);
Console.WriteLine();
ChangeArray(array);