// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Ведите число: ");
int dec = Convert.ToInt32(Console.ReadLine());
string ConvertToBin(int a)
{
    string bin1 = Convert.ToString(a);
    string bin2 = "";
    while (a > 0)
    {
        bin2 = (a % 2) + bin2;
        a = a / 2;
    }   
    return bin2;
}
Console.WriteLine(ConvertToBin(dec));