// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int newNumber1 = number1*number1;
int newNumber2 = number2*number2;

if (number1 == newNumber2 | number2 == newNumber1)
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("Не является квадратом");
}