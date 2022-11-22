// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }

    return result;
}

Console.Write("Enter Line: ");
int Line = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Column: ");
int Column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[Line, Column];

if( Line == Column)
{
    FillArray(array);
    Console.WriteLine();
    int[,] resultArray = ChangeArray(array);
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write(resultArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

else 
{
    Console.WriteLine("Массив не квадратный поменять нет возможности");
}