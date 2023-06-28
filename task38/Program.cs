// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] array = GetArray(5);
Console.WriteLine(String.Join ("|", array )); 
Console.WriteLine($"Разница равна = {GetDifference(array)}");



double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*10 + new Random().Next();
        result[i] = Math.Round(result[i], 3);
    }
    return result;
}


double GetDifference(double [] array)
{

    double min = array [0];
    double max = array [0];

    foreach (double el in array)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}