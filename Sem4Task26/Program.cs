// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1); // Введите число: (водим число)
    Console.WriteLine(msg2);
}
// Вариант 1 
// Решение при помощи целочисленного деления
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num / 10; // 256 / 10 = 25; 25 / 10 = 2; 2 / 10 = 0
    }
    return res;
}
// Вариант 2
// Решение при помощи преобразования в строку
int SumDigStr(int num)
{
    int res = 0;
    res = num.ToString().Length; // 123 -> "123" -> length
    return res;
}
// Вариант 3
// Решение при помощи десятичного логарифма
int VariantLog(int num)
{
    int count = (int)Math.Log10(num) + 1; // Log10(256)
    return count;
}

int number = ReadData("Введите число: ");
// Замер времени при помощи варианта 1
DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Вариант (SumDigit): ", res1);
// Замер времени при помощи варианта 2
DateTime d2 = DateTime.Now;
int res2 = SumDigStr(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Вариант (SumDigStr): ", res2);
// Замер времени при помощи варианта 3
DateTime d3 = DateTime.Now;
int res3 = VariantLog(number);
Console.WriteLine(DateTime.Now - d3);
PrintData("Вариант (VariantLog): ", res3);


