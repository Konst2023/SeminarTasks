// Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.
// 1 2 3 
// 1 2 3 
// 1 2 3 
// 1 2 3 
// 1 2 3 
// sum = 6



// Запрос числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] Fill2DArr(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void Print2DArr(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(1, 16));
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;
    }
}
// Сумма диагональных элементов матрицы
int DiagSum(int[,] arr)
{
    int dSum = 0;
    int minDim = arr.GetLength(0) <= arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    for (int i = 0; i < minDim; i++)
    {
        dSum += arr[i, i]; // идем строго по диагонали за 1 цикл!!!
    }
    return dSum;
}

//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1 + msg2);
}

int xlen = InputNum("Ваше число строк: ");
int ylen = InputNum("Ваше число столбцов: ");
int[,] matrix = Fill2DArr(xlen, ylen);
Print2DArr(matrix);
PrintData("Сумма чисел на диагонали = ", DiagSum(matrix));


