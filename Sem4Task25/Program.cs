// 25) Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.   
// 3, 5 -> 243 (3⁵) 
//  2, 4-> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень 

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, long msg2)
{
    Console.WriteLine(msg1 + msg2);
}
// Функция возведения в степень
long Pow(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        b = b - 1;
        res = res * a;
    }

    return res;
}

int a = ReadData("Введите число A: ");
int b = ReadData("Введите число B: ");
long pw = Pow(a, b);
PrintData("Результат: ", pw);