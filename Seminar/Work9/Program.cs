// Напишите программу, которая принимает на вход координаты точки (X и Y).
// Причем  X = 0 и Y = 0 и выдает номер четверти плоскости, в которой находится эта точка.

//<Возвращ. тип данных> <Наименование метода>(переменные){тело метода}
int GetPointArea(int coordX, int coordY)
{
    if (coordX > 0 && coordY > 0)
    {
        return 1;
    }
    if (coordX < 0 && coordY > 0)
    {
        return 2;
    }
    if (coordX < 0 && coordY < 0)
    {
        return 3;
    }
    if (coordX > 0 && coordY < 0)
    {
        return 4;
    }
    return 0;
}

Console.WriteLine("Введи X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
Console.WriteLine(numberArea);