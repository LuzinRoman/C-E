// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Main();

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetDigits(int A, int B)

{
    int result = 1;
for(int i = 1; i<=B; i++)
{
    result = result * A;
}
return(result);
}

void Main()
{
int numberA = Prompt("Введите число А: ");
int numberB = Prompt("Введите число B: ");
int result = GetDigits(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} = " + result);
}