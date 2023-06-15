// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Ведите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber = ((number%100 - number%10)/10);
if (number>=100 & number<1000)

{
   
    Console.WriteLine($"Вторая цифра числа: {SecondNumber}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}


