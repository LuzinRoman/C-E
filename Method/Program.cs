// Вид 1

void Method ()
{
    Console.WriteLine ("Меня зовут...");
}
// Method();

 // Вид2
void Method2(string msg)
{
    Console.WriteLine (msg);
}
// Method2(msg: "Меня зовут...");

void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
    Console.WriteLine(msg);
    i++;
   }
}
// Method21(msg: "Меня зовут...", count: 5);

// Вид3

int Method3()
{
    return DateTime.Now.Year;
}
// int Year = Method3();
// Console.WriteLine(Year);

// Вид 4

string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

