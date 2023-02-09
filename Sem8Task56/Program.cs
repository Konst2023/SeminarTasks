// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j].ToString() + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Поиск строки массива с минимальной суммой элементов
// 1 2 3 -> 6
// 1 3 5 -> 9
// 2 4 6 -> 12
int StrNum(int[,] arr)
{
    int minSum = int.MaxValue;
    int strNumber = -1; // указывает в никуда

    for (int i = 0; i < arr.GetLength(0); i++) // по всем строкам
    {
        int strSum = 0;  // сумматор
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            strSum += arr[i, j];
        }
        if (strSum < minSum)  // если сумма строки минимальна
        {
            minSum = strSum;  // переписываем мин
            strNumber = i;  // запоминаем номер строки
        }
    }
    return strNumber;
}
// Вывод сообщения
void PrintMsg(string msg)
{
    Console.WriteLine(msg);
}


int cols = ReadData("Строк: ");
int rows = ReadData("Столбцов: ");
int[,] arr = Gen2DArray(cols, rows, 1, 9);
Print2DArray(arr);
int strNum = StrNum(arr);
PrintMsg($"Минимальная сумма элементов в {strNum + 1} строке");

