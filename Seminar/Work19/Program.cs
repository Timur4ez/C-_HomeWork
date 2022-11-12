// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] array = new int[123];
int sumarray = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 124);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
    {
        sumarray += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Значение равно = {sumarray}");