// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
string strNum = number.ToString();
int[]array = new int[strNum.Length];
int sum = 0;

for (int i = 0; i < strNum.Length; i++)
{
    array[i] = int.Parse(strNum[i].ToString());
    sum = sum + array[i];
}
Console.WriteLine(sum);