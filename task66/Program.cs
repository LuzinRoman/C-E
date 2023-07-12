
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

    Main(args);

    int SumOfElements(int minValue, int maxValue)
    {
        if (minValue == maxValue)
        {
            return maxValue;
        }
        else
        {
            return minValue + SumOfElements(minValue + 1, maxValue);
        }
    }

    void Main(string[] args)
    {
        int M = 1;
        int N = 15;

        int sumOfElements = SumOfElements(M, N);

        Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1}: {2}", M, N, sumOfElements);
    }