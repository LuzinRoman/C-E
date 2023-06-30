// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x + b1 = k2*x + b2, x (k1-k2) = b1 - b2

double b1 = Prompt("Введите значение точки b1: "); 
double k1 = Prompt("Введите значение точки k1: "); 
double b2 = Prompt("Введите значение точки b2: "); 
double k2 = Prompt("Введите значение точки k2: "); 


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
       
    double x = - (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Координаты пересечения точек: x = {x}, y = {y}");

   
    