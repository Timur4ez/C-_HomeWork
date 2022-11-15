// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Write("Ведите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.Write("Массив [{0}]", string.Join(", ", array));
for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.WriteLine();
Console.Write("Массив [{0}]", string.Join(", ", array));