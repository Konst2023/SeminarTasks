// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N. Выполнить с помощью рекурсии.

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
// num = 5 -> _5
// num = 4 ->   _4
// num = 3 ->     _3
// num = 2 ->       _2
// num = 1 ->         _1
// num = 0 ->           ""
// 
// Вывод строки от указанного числа до 1 
string LineGenRec(int num)
{
    if(num == 0) return string.Empty;   
    else return  LineGenRec(num - 1) + " " + num; // заполняем справа на лево
}

int number = ReadData("Введите число N: ");
PrintResult(LineGenRec(number));
