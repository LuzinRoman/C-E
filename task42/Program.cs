// Задача 42: Напишите программу, которая будет преобразовывать десятичное 
// число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string toBynary(int n)
{
    string result = "";
    while(n  > 0)
    {
        result += Convert.ToString(n % 2);
        n/=2;
    }
    return ReverseString(result);
}
Console.WriteLine($"{toBynary(num)}");

static string ReverseString(string s)
    {
        // Convert to char array, then call Array.Reverse.
        // ... Finally use string constructor on array.
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }