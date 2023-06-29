// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число больше двух: ");
int N = int.Parse(Console.ReadLine());
PrintArray(Fibonachi(N));
Console.Write("Числа Фибоначи");

int [] Fibonachi (int N)
{
 int [] fibonachi = new int [N];

 fibonachi [0] = 0;
 fibonachi [1] = 1;

 for (int i = 2; i<N; i++)
 fibonachi[i] = fibonachi[i-1] + fibonachi[i - 2];

return fibonachi;
}

void PrintArray(int[] array)
{
  
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}


