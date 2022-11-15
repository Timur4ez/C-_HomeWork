// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Ведите три числа ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int A, int B, int C)
{
    if(A < B + C)
    {
        if(B < A + C)
        {
            if(C < A + B)
            {
                return true;
            }
            else return false;
        }
        else return false;
    }
    else return false;
}
Console.WriteLine(IsTriangle(A, B, C));
