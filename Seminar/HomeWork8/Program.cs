Console.WriteLine("Введите число > 0: ");
int n = Convert.ToInt32(Console.ReadLine());
int number = 1;

//Строка 6 по сути лишняя, но так мы исключим отрицательные числа.
if (n < 0) Console.WriteLine("И в каком месте это число > 0");

while(number <= n)
{
    if (number % 2 == 0) 
    {
        Console.WriteLine($"Чётное число: {number}");
    }
    number = number + 1;
}