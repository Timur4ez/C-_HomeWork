//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int a = (number / 10) % 10;
    Console.WriteLine($"Второая цифра этого числа: {a}");
}
else
{
        Console.WriteLine($"Число не трёхзначное");
} 