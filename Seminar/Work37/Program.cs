// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumRec(int number)
{
 if (number == 0) return 0;
 else return number + SumRec(number - 1);
}
Console.WriteLine(SumRec(number));