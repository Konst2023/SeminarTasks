// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// 1 2 3 4
// 1 2 3 4 
// -------
// 1 2 3 4 - одномерный массив вещественных чисел

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
// Печать одномерного вещественного массива
void Print1DDblArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(String.Format("{0:f2}", arr[i] + ", "));
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//  Вычисление среднего арифметического столбцов массива
double[] AvrArithm(int[,] arr)
{    
    int rowNum = arr.GetLength(0); // число строк
    int colNum = arr.GetLength(1); // число столбцов
    double[] res = new double[colNum]; 
    for (int j = 0; j < colNum; j++) // по всем столбцам
    {
        double sum = 0;
        for (int i = 0; i < rowNum; i++)
        {
            sum += arr[i, j];
        }
        res[j] = sum / rowNum; // среднее арифметическое
    }
    return res;
}

// Генерация двумерного массива
int[,] matrix = FillTwoDimArray(5, 5); //массив 5x5

// Печатаем двумерный массив
PrintTwoDimArray(matrix);
double[] avrMtx = AvrArithm(matrix);
Console.WriteLine("Среднее арифметическое столбцов массива:");
Print1DDblArr(avrMtx);