
// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет


int rows = Prompt("Введите индекс строки: ");
int columns = Prompt("Введите индекс столбца: ");

int[,] array = GetArray(rows, columns);
PrintArray(array);

if (rows < array.GetLength(0) && columns < array.GetLength(1))
{
    Console.WriteLine($"Значение элемента [{rows}, {columns}]: {array[rows, columns]}");
}
else 
{
    Console.WriteLine($"[{rows}, {columns}] -> числа с таким индексом в массиве нет");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[3, 4] // Размер массива задаем сами
    {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}



















// int rows = Prompt("Введите индекс строки: ");
// int columns = Prompt("Введите индекс столбца: ");

// int[,] array = GetArray(rows, columns);
// PrintArray(array, rows, columns);

// if (rows < array.GetLength(0) && columns < array.GetLength(1))
// {
//     Console.WriteLine($"Значение элемента [{rows}, {columns}]: {array[rows, columns]}");
// }
// else 
// {
//     Console.WriteLine($"{rows}, {columns} -> числа с таким индексом в массиве нет");
// }

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int[,] GetArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(1, 10); 

//         }
//     }
//     return result;
 
// }
//   Console.WriteLine();


// void PrintArray(int[,] arr, int rowIndex, int columnIndex)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
  
// // void PrintArray(int[,] arr, int rowIndex, int columnIndex)
// // {
// //     for (int i = 0; i < arr.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < arr.GetLength(1); j++)
// //         {
// //             if (i == rowIndex && j == columnIndex)
// //             {
// //                 Console.WriteLine($"Значение элемента [{i}, {j}]: {arr[i, j]}");
// //             }
// //         }
// //     }
// // }






