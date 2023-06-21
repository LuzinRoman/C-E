// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = Prompt("Введите число: ");
Square(num);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Square(int number)
{
int i = 1;
while (i<=number)
{
    Console.Write(i*i*i + " ");
    i++;
}
}