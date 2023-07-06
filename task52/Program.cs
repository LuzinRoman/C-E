// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
Console.WriteLine();
int[,] array = GetArray(rows, columns);
PrintArray(array);
GetAverage(array);

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
            result[i, j] = new Random().Next(1, 10); 

        }
    }
    return result;
 
}
  Console.WriteLine();

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


void GetAverage(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
               
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
            Console.WriteLine(arr[i, j] + " ");
        }
        
        double average = sum / arr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое значений в столбце {j+1}: {Math.Round(average, 1)}");
       
    }
}


