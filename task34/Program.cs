// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = Prompt("Введите размерность массива: ");
int[] numbers = new int[size];

RandomArray(numbers);
PrintArray(numbers);
Console.WriteLine("Массив случайных положительных трехзначных чисел");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


void RandomArray(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;
for (int n = 0; n < numbers.Length; n++)
{
if (numbers[n] % 2 == 0)
count++;
}
Console.WriteLine($"В массиве из {numbers.Length} чисел, {count} четных");

void PrintArray(int[] numbers)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (int el in numbers)
    {
        Console.Write($"{el} ");
    }
}


