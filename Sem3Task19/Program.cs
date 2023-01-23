// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (одинаково читается слева-направо и справа-налево).
// 12321, 58985

// Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}
// Вывод данных
void PrintData(bool res)
{
    if (res == true)
    {
        Console.WriteLine("Является палиндромом.");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }

}
// Проверка числа на палиндромность
bool PalinTest(int number) // Вариант 1
{
    bool res = false;
    int d1 = number / 10000; // первый знак 12321 / 10000 = 1
    int d2 = (number / 1000) % 10; //второй знак 12321 / 1000 = 12, 12 % 10 = 2
    int d3 = (number / 10) % 10; // четвертый знак 12321 / 10 = 1232, 1232 % 10 = 2
    int d4 = number % 10; // пятый знак = 1
    res = (d1 == d4) && (d2 == d3) ? true:false;    
    return res;
}
// Вариант2 - перевести в массив символов и сравнить элементы массива


string strNumber = ReadData("Введите пятизначное число: ");
// Проверка числа на пятизначность
if (strNumber.Length == 5)
{
    PrintData(PalinTest(int.Parse(strNumber)));
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}

