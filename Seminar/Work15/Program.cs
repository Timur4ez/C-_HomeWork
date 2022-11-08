// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Console.Write("Enter a number:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
for (int i = 0; i< size - 1; i++)
{
    int item = new Random().Next(0, 2);
    array[i] = item;
}
Console.WriteLine("[{0}]", string.Join(", ", array));