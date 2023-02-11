// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

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
// num = 5 -> 5_
// num = 4 ->   4_
// num = 3 ->     3_
// num = 2 ->       2_
// num = 1 ->         1_
// num = 0 ->           ""

string LineGenRec(int num)
{
    if (num == 0) return string.Empty;
    else return num + " " + LineGenRec(num - 1); // заполняем слева направо    
}

int number = ReadData("Введите число N: ");
PrintResult(LineGenRec(number));
