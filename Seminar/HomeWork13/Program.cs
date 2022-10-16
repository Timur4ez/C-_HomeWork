Console.WriteLine("Введите число: ");
string array = Console.ReadLine();

if(array.Length < 3) {Console.WriteLine("Нет третей цифры");}
else Console.WriteLine($"Третье введенное число в массиве: {array[2]}");
