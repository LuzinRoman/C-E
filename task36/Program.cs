// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Prompt("Введите размерность массива: ");
int[] numbers = new int[size];
RandomArray(numbers);
PrintArray(numbers);

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
        numbers[i] = new Random().Next(-100,100);
    }
}

int sum = 0;
for (int n = 1; n < numbers.Length; n += 2)
{
    sum = sum + numbers[n];
}
Console.WriteLine($"В массиве из {numbers.Length} чисел сумма чисел стоящих на нечетных позициях равна {sum}");


void PrintArray(int[] numbers)
{
   
    foreach (int el in numbers)
    {
        Console.Write($"{el} ");
    }
}
