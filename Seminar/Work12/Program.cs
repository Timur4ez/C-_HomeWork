﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int number)
{
    int sum = 0;

    int tempVilue = 1;
    while (tempVilue <= number)
    {
        sum = sum + tempVilue;
        tempVilue = tempVilue + 1;
    }

    return sum;
}

Console.Write("Ведите число А:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSum(number);
Console.WriteLine(sum);
