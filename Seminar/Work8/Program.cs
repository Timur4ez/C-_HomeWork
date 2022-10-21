// Напишите программу, которая принимает на вход координаты точки (X и Y).
// Причем  X = 0 и Y = 0 и выдает номер четверти плоскости, в которой находится эта точка.

//<Возвращ. тип данных> <Наименование метода>(переменные){тело метода}
int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }
    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }
    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }
    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}

Console.WriteLine("Введи X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
Console.WriteLine(numberArea);