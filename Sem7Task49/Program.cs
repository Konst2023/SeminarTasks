// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.
// Запрос ввода числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn)
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
void Print2DArray(int[,] inputArray)
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
// Обновление эл-тов массива согласно условиям задачи
void Update2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {            
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
}



int xlen = InputNum("Число строк: ");
int ylen = InputNum("Число столбцов: ");
int[,] matrix = Fill2DArray(xlen, ylen);
Print2DArray(matrix);
Update2DArr(matrix);
Console.WriteLine();
Print2DArray(matrix);
