// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int XA = Prompt("Введите координаты точки XA: ");
int YA = Prompt("Введите координаты точки YA: ");
int ZA = Prompt("Введите координаты точки ZA: ");
int XB = Prompt("Введите координаты точки XB: ");
int YB = Prompt("Введите координаты точки YB: ");
int ZB = Prompt("Введите координаты точки ZB: ");

int Prompt(string message)

{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));
Console.WriteLine(AB);