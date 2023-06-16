// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int x = Prompt("Введите координату точки X: ");
int y = Prompt("Введите координату точки Y: ");
FindQuater(x,y);
// Console.Write(X + " " +Y);

void FindQuater(int X, int Y)

{
    if(X>0 && Y>0)
{
    Console.WriteLine(" 1 я четверть");
}
else if(X<0 && Y>0)
{
     Console.WriteLine(" 2 я четверть");
}
else if (X<0 && Y<0)
{
     Console.WriteLine(" 3 я четверть");
}
else if(X>0 &&Y<0)
{
    Console.WriteLine(" 4 я четверть");
}
else
{
    Console.WriteLine(" Ошибка координат");
}

}