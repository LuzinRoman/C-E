// /Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");


int[,] array = GetArray(rows, columns);
PrintArray(array);

Console.WriteLine();

int sum = Sum(array);
PrintNumber(sum);
Console.WriteLine("Сумма по главной диагонали:" + sum);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]

        }
    }
    return result;
}


int Sum(int[,] array)
{
     int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
            {
            result = result + array[i,i];
        }
    }
    return result;
}


void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - длина столбцов
        {
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
}

void PrintNumber(int number)
{
    Console.WriteLine();
}
