// Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

Console.Write("Введите сколько чисел вы закините в массив: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Ведите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = PositiveNumbers(array);
Console.Write($"Сумма элементов: {sum}");
