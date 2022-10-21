// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string Range(int num)
{
string a = "0 ";

if (num == 1) a = "X > 0; Y > 0; ";
if (num == 2) a = "X < 0; Y > 0; ";
if (num == 3) a = "X < 0; Y < 0; ";
if (num == 4) a = "X > 0; Y < 0; ";
return (a);
}

Console.WriteLine("введи номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string pos = Range(num);
Console.WriteLine(pos);