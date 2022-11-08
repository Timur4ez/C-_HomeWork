// Напишите программу которая принимает на вход координаты двух и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Enter the number of spaces: ");
int spaces = Convert.ToInt32(Console.ReadLine());
double distance = 0;
for (int i = 1; i <= spaces; i++)
{
    Console.Write("Enter the coordinates1: ");
    int coor1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the coordinates2: ");
    int coor2 = Convert.ToInt32(Console.ReadLine());
    distance = distance + Math.Pow(coor2 - coor1, 2);     
}
distance = Math.Sqrt(distance);
Console.WriteLine($"Длинна отрезка {distance}");