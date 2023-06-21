// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Prompt("Введите число: ");
Square(number);
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int i = 1;
void Square(int number)
while (i<=number)
{
    Console.Write(i*i + " ");
    i++;
}