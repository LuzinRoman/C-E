
// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7 обозначающую день недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());


if (numDay > 0 && numDay < 6)
{
    Console.WriteLine("Я плачу....рабочий день");
}
else if (numDay == 6 || numDay == 7)
{
     Console.WriteLine("Ураааа бухаем выходной");
}
else
{
    Console.WriteLine("Дык...таки вообще цифирь не про неделю");
}
