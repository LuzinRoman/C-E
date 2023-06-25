// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine());


// Вызываем оба метода и выводим на консоль сумму цифр в числе
int len = GetDigits(number);
int sum = GetSum(number, len);
 Console.WriteLine(sum);


// Создаем метод подсчета цифр в числе
int GetDigits(int num)
{
    int index = 1;
    while (num>0)
    {
      num /= 10;
      index++;
    }
    return index;
    
}

// Создаем метод подсчета суммы цифр в числе 

int GetSum(int number, int len)
{
int sum = 0;
for(int i = 1; i <= len; i++)
{
    {
        sum += number % 10;
        number /= 10;
    }
 }
 return sum;
}


