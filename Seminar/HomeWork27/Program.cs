// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
string strNumber = number.ToString();
int[] array = new int[strNumber.Length];
int sum = 0;
for (int i = 0; i< strNumber.Length; i++)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);