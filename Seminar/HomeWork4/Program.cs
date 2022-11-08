Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"max = {max}");