// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
 
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int getDigit(int number)
{
 int i = 0;
while (number>=1)
{
    number = number / 10;
    i++;
}
  return i;
}
int digits = getDigit(number);
Console.WriteLine(digits);



