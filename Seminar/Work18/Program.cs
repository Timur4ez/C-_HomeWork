// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// bool Search(int[] sourceArray, int value) {}

int[] array = new int[10];
bool Search(int[] sourceArray, int value) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (sourceArray[i] == value) 
        {
            return true;
        }
    }
    return false;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine("Введите число которое нужно найти: ");
int value = Convert.ToInt32(Console.ReadLine());
bool Result = Search(array, value);
Console.Write(Result);