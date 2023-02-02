// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Решение:
// k1*x + b1 = k2*x + b2
// x*(k1-k2) = b2-b1
// x=(b1-b2)/(k1-k2), подставим x в 1-е уравнение
// y = k1 * x + b1, получим у

double k1 = 0;
double k2 = 0;
double b1 = 0;
double b2 = 0;
//  Ввод коэф-тов для двух прямых
void InputData()
{
    System.Console.Write("Введите k1: ");
    k1 = double.Parse(Console.ReadLine() ?? "0");

    System.Console.Write("Введите k2: ");
    k2 = double.Parse(Console.ReadLine() ?? "0");

    System.Console.Write("Введите b1: ");
    b1 = double.Parse(Console.ReadLine() ?? "0");

    System.Console.Write("Введите b2: ");
    b2 = double.Parse(Console.ReadLine() ?? "0");
}
// Вычисление точки пересечения и печать результата
void CalcAndPrint()
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("x = " + x + " y = " + y);
}
    

InputData();
CalcAndPrint();

