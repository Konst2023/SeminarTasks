// Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1); // Результат: 256
    Console.WriteLine(msg2);
}
// Вычисление суммы чисел при помощи цикла
int SumSimple(int numA)
{
    int sumOfNum = 1;
    for (int i = 2; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}
// Решение 2
// Вычисление суммы чисел по формуле Гаусса
int SumGauss(int numA)
{
    return (numA * (numA + 1)) / 2;
}

int numberA = ReadData("Введите число A: ");

// Время выполнения функции 1
DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);
// Время выполнения функции 2
DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А(SumSimple): ", res1);
PrintData("Сумма чисел от 1 до А(SumGauss): ", res2);
