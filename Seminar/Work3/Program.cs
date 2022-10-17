//Случайное число
int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;

if (a1 > a2) Console.WriteLine($"Наибольщая цифра в числе {a1}");
if (a2 > a1) Console.WriteLine($"Наибольщая цифра в числе {a2}");
if (a2 == a1) Console.WriteLine($"Цифры в числе равны");

Console.WriteLine(number);
Console.ReadKey();