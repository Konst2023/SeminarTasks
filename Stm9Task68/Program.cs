// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

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

// Метод вычисления функции Аккермана:
// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0#%D0%A0%D0%B5%D0%B0%D0%BB%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F
// В псевдокоде функция Аккермана реализуется по определению (Википедия): 
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

// Решение по псевдокоду из Википедии
int Ack1(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ack1(n - 1, 1);        
    return Ack1(n - 1, Ack1(n, m - 1));
}

// Решение из https://github.com/IntentG/31.HomeWork_68.task/blob/master/Program.cs
int Ack2(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Ack2(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Ack2(numberM - 1, Ack2(numberM, numberN - 1));
    return Ack2(numberM, numberN);
}

int numN = ReadData("Введите начальное число N: ");
int numM = ReadData("Введите начальное число M: ");

PrintResult($"Функция Аккермана[1] для чисел A({numN},{numM}) = {Ack1(numN, numM)}");
PrintResult($"Функция Аккермана[2] для чисел A({numN},{numM}) = {Ack1(numN, numM)}");

// (0,3), (0,4) - ошибки по таблице Википедии!
