Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 | x > 7 )
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (x == 1) Console.WriteLine("Это же понедельник!");
    if (x == 2) Console.WriteLine("Это же вторник!");
    if (x == 3) Console.WriteLine("Это же среда!");
    if (x == 4) Console.WriteLine("Это же четверг!");
    if (x == 5) Console.WriteLine("Это же пятница!");
    if (x == 6) Console.WriteLine("Это же суббота!");
    if (x == 7) Console.WriteLine("Это же воскресенье!");
}