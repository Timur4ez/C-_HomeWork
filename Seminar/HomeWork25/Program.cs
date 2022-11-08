// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter degree: ");
int degree = Convert.ToInt32(Console.ReadLine());
//Строка 8 альтернативный вариант
//number = Math.Pow(number, degree);  
int sum = number;
for(int i = 0; i < degree - 1; i++)
{
    sum = sum * number;
}
Console.WriteLine($"{sum}");