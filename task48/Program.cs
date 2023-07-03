// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");

int[,] array = GetArray(rows, columns);
PrintArray(array);

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
            result[i, j] = i + j;

        }
    }
    return result;
}

void PrintArray(int[,] arr)
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