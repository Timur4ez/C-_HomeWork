// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива
// Возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю.
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int arrayLine = ReadInt("Введите сколько строк в массиве: ");
int arrayColumn = ReadInt("Введите сколько столбцов в массиве: ");
int line = ReadInt("Введите индекс строки: ");
int column = ReadInt("Введите индекс столбца: ");
Console.WriteLine();

int[,] numbers = new int[arrayLine, arrayColumn];
FillArray(numbers);

if (line < numbers.GetLength(0) && column < numbers.GetLength(1)) 
{
    Console.WriteLine(numbers[line, column]);
}
else Console.WriteLine($"{line}{column} -> такого числа в массиве нет");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}