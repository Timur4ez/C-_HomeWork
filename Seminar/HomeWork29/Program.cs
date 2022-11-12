// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива № {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив [{0}]", string.Join(", ", array));
