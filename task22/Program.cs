// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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
    Console.Write(i*i + " ");
    i++;
}
}