// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double SearchMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    double result = max - min;
    return result;
}

Console.Write("Ведите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 10;
}
Console.WriteLine("Массив [{0}]", string.Join("; ", array));
double result = SearchMaxMin(array);
Console.WriteLine($"Разница между минимальным и максимальным значением: {result}");