// Задайте значения M и N. Напишите программу, которая найдёт все натуральные 
// числа в промежутке от M до N

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
// Вывод натчисел от m до n
string RecLineMN(int m, int n)
{
    if (n == m) return n.ToString();    
    else return m + " " + RecLineMN(m + 1, n); // заполняем слева направо
}

int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
string res = m > n ? RecLineMN(n, m) : RecLineMN(m, n);
PrintResult(res);