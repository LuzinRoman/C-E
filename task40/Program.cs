// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли
//  существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
// суммы двух других сторон.


int a = Prompt("Введите сторону1:");
int b = Prompt("Введите сторону2: ");
int c = Prompt("Введите сторону3: ");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool isTriangle(int A, int B, int C)
{
    return (A + B > C) && (A + C > B) && (B + C > A); 
}
if (isTriangle(a,b,c))
{
    Console.WriteLine("Является треугольником: ");
}
else
{
    Console.WriteLine("Не является треугольником: ");
}