// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sumarray = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
        if(array[i] % 2 ==0)
        {
            sumarray += 1;
        }
}
Console.Write("Массив [{0}]", string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Значение равно = {sumarray}");