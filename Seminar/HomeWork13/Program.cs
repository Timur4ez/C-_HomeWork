//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastnumber = number % 10;

if (99 < number)
{
    Console.WriteLine($"Третья цифра заданного числа: {lastnumber}");
}
else
{
    Console.WriteLine("Третей цифры нет");
}