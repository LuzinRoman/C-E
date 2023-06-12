// // Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число, которому соответствует день недели: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.Write("Опять понедельник:(( ");
}
else if (day == "2")
{
    Console.Write("Вторник ");
}
else if (day == "3")
{
    Console.Write("Среда ");
}
else if (day == "4")
{
    Console.Write("Четверг");
}
else if (day == "5")
{
    Console.Write("Пятницца");
}
else if (day == "6")
{
    Console.Write("Суббота");
}
else if (day == "7")
{
    Console.Write("Воскресение");
}
else
{
    Console.WriteLine("Это вообще не день недели");
}