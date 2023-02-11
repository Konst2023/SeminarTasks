// Напишите программу, которая будет принимать два числа A и B и возводить число A в степень B,
// с помощью рекурсии.

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
// Рекуррентный вариант возведения в степень последовательно
long RecPowFlow(int a, int b)
{
    if (b <= 1) return a;
    else return a * RecPowFlow(a, b - 1);
}
// Рекуррентный вариант возведения в степень группами по 2
long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    return MyPow(a, b / 2) * MyPow(a, b / 2);
}

long res1 = 0;
long res2 = 0;

int numA = ReadData("Число A: ");
int numB = ReadData("Число B: ");

DateTime d1 = DateTime.Now;
res1 = MyPow(numA, numB);
PrintResult("Решение MyPow: " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = RecPowFlow(numA, numB);
PrintResult("Решение RecPowFlow: " + (DateTime.Now - d2));

PrintResult($"{numA} в степени {numB} = {res2}");

