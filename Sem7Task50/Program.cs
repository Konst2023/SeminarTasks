// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Запрос числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(10, 100);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));            
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }       
        Console.WriteLine();
        i++;
    }
}

int CheckElem(int [,] arr, int x, int y)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1)) return arr[x, y];
    else return -1;
}

//1) Получение данных от пользователя
int n = InputNum("Номер строки: ");
int m = InputNum("Номер столбца: ");

//2) Генерация двумерного массива
int[,] matrix = FillTwoDimArray(5, 5); //массив 5x5

//3) Печатаем двумерный массив
PrintTwoDimArray(matrix);

// Для пользователя строки и столбцы нумеруются с единицы
if (CheckElem(matrix, n, m) != -1) Console.WriteLine("Указан элемент: " + matrix[n-1, m-1]); 
else Console.WriteLine("Такого элемента нет!");
