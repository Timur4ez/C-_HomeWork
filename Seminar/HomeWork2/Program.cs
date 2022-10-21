Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a, min = a; 

if(a > max) max = a;
if(b > max) max = b;
if(a < min) min = a;
if(b < min) min = b;

Console.WriteLine($"min = {min}");
Console.WriteLine($"max = {max}");
