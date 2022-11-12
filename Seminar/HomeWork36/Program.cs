// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int SumNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начало числового диапазона: ");
int numberAreaStart = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец числового диапазона (число должно быть > начального): ");
int numberAreaEnd = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(numberAreaStart, numberAreaEnd);
}
int sum = SumNumber(array);
Console.WriteLine("Новый массив [{0}]", string.Join(", ", array));
Console.Write($"Сумма элементов: {sum}");