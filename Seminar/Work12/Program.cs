// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void PrintSquareaToConsole(int n);
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++);
{
    Console.WriteLine(i * i);
}

PrintSquareaToConsole(10);
for (int i = 1; i <=5; i++)
{
   Console.WriteLine(i);
}
//void PrintResult(string message)
//{
//    Console.Write(message);
//}