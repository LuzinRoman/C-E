// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в 
// этой четверти (x и y).

int number = Prompt("Введите номер четверти: ");

FindNumberQuater(number);


int Prompt(string message)

{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Console.Write(X + " " +Y);

void FindNumberQuater(int number)
{
    if(number == 1)
{
        Console.WriteLine(" X > 0, Y > 0");
}
else if(number == 2)
{
     Console.WriteLine(" X < 0, Y > 0");
}
else if (number == 3)
{
     Console.WriteLine("X < 0, Y < 0");
}
else if (number == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else
{
    Console.WriteLine(" Такой четверти нет");
}
}
