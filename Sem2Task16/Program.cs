// Является ли одно число квадратом второго (два варианта)

Console.WriteLine("Введите 2 числа: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа

//сравнение возведённого в квадрат числа с другим числом
void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i);
    }
}


TestSQRT(num1, num2);
TestSQRT(num2, num1);
