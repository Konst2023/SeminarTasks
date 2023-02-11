// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

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
// N, N-1... 2, 1
// Складываем числа в заданном интервале
int CountLineMN(int m, int n)
{
    if (n == m) return n;
    else return m + CountLineMN(m + 1, n); // заполняем слева направо
}

int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
int res = m > n ? CountLineMN(n, m) : CountLineMN(m, n);
PrintResult($"Сумма чисел от {n} до {m} равна {res}");