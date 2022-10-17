//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int a1 = number / 100;
int a2 = number % 10;
int result = a1 * 10 + a2;
Console.WriteLine($"Удалить второе число получается: {result}");