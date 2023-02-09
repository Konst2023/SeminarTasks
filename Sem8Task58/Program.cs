// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
// Выбор строки из матрицы
int[] RowFromArr(int[,] arr, int rowNum)
{
    int rowLength = arr.GetLength(1);
    int[] row = new int[rowLength];

    for (int j = 0; j < rowLength; j++)
    {
        row[j] = arr[rowNum, j];
    }
    return row;
}
// Выбор столбца из матрицы
int[] ColFromArr(int[,] arr, int colNum)
{
    int colLength = arr.GetLength(0);
    int[] column = new int[colLength];

    for (int i = 0; i < colLength; i++)
    {
        column[i] = arr[i, colNum];
    }
    return column;
}

// Перемножение строк одинаковой длины -> число
int ScalarMulti(int[] arr1, int[] arr2)
{    
    int res = 0;
    for (int i = 0; i < arr1.Length; i++) res += arr1[i] * arr2[i];
    return res;
}

// Перемножение двух массивов
int [,] Multi2DArray(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)]; // 

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            res[i, j] = ScalarMulti(RowFromArr(arr1, i), ColFromArr(arr2, j));
        }
    }

    return res;
}
// Вывод сообщения пользователю
void PrintMsg(string msg)
{
    Console.WriteLine(msg);
}

int cols = ReadData("Строк: ");
int rows = ReadData("Столбцов: ");
PrintMsg("Матрица 1:");
int[,] arr1 = Gen2DArray(cols, rows, 1, 2);
Print2DArray(arr1);
PrintMsg("Матрица 2:");
int[,] arr2 = Gen2DArray(cols, rows, 1, 2);
Print2DArray(arr2);
PrintMsg("Произведение матриц:");
int[,] arr3 = Multi2DArray(arr1, arr2);
Print2DArray(arr3);

