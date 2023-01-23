// Напишите программу, которая по заданному номеру
// четверти указывает допустимый диапазон точек в этой четверти

int qNum = ReadData("Введите номер четверти: ");
PrintQuaterAnswer(qNum);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод определяет допустимого диапазона координат точек по четверти
void PrintQuaterAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("X > 0, Y > 0");
        if (num == 2) Console.WriteLine("X > 0, Y < 0");
        if (num == 3) Console.WriteLine("X < 0, Y < 0");
        if (num == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти!");
}
