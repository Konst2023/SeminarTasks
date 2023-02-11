// Задайте значение N. Напишите программу, которая принимает на вход число и возвращает сумму цифр в числе N.
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// 157
// 157 % 10 -> 7
// f(15) -> 15 % 10 -> 5
// f(1)
// Сумма цифр в числе рекурсией
int SumDigits(int n)
{
    if (n <= 10) return n;
    return n % 10 + SumDigits(n / 10);
}
// Сумма цифр в числе циклом
int SumDig(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    return res;
}

int n = ReadData("Введите число N: ");
PrintResult("Сумма цифр в числе: " + SumDigits(n) + ", способ 2: " + SumDig(n));

