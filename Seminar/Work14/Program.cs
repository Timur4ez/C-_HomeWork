// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
//string strNumber = Math.Abs(number).ToString();
int GetSum(int number)
{
    int sum = 1;
    for (int i = 1; i<= number; i ++)
    {
        sum = sum * i;
    }
    
    return sum;
}
int sum = GetSum(number);
Console.WriteLine(sum);