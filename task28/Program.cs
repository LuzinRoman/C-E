// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите положительное число: ");
// int number = int.Parse(Console.ReadLine());


// int Factorial(int number)
// {while (number>=1)
// {
//   for (int i = 1; number>=1; i++);
// return num;
// }
// }

// int num = Factorial(int );
// Console.WriteLine(num);


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

while (number <=0)
{
    Console.WriteLine("Введи положительное цело число, больше нуля");
    number = Convert.ToInt32(Console.ReadLine());
}

int result = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++) checked {fact *= i;} 
    return fact;
}
