// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Numbers(int n)
{
    if (n == 1)
    {
        return 1;
    }
    Console.Write(n + ", ");
    return Numbers(n - 1);
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Number = Numbers(n);
Console.WriteLine(Number);