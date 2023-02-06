// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// запрос числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] Fill2DDblArr(int countRow, int countColumn, double minVal, double maxVal)
{
    Random rnd = new Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = minVal + rnd.NextDouble() * (maxVal - minVal); // 1 + 0.12587 * (10 - 1)           
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void Print2DDblArr(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));            
            Console.Write(String.Format("{0:f2}", inputArray[i, j]) + " ");
            Console.ResetColor();
            j++;
        }        
        Console.WriteLine();
        i++;
    }
}

//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");

//2) Генерация двумерного вещественного массива
double[,] matix = Fill2DDblArr(n, m, 10, 100);

//3) Печатаем двумерный массив
Print2DDblArr(matix);
