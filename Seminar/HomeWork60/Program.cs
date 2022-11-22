// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] array)
{
    int xD = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i,j,z] = xD;
                xD++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
         for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i,j,z]} [{i},{j},{z}] ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array = new int[2,2,2];
FillArray(array);
PrintArray(array);