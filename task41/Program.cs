// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int size = Prompt("Введите количество элементов массива: ");
int[] Array = new int [size];

PlusNum(size);
int sum = GetSum(Array);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PlusNum (int size)
{
for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1} элементов массива");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
}

int GetSum (int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if(Array[i] > 0)
        sum += 1;
        i += 1;
    }
    return sum;
}

Console.Write($"Количество чисел больше нуля: {sum}");


