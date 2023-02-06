// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Запрос числа
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Создание двумерного массива по условиям задачи
int[,] CreateArray(int xlen, int ylen)
{
    int[,] arr = new int[xlen, ylen];
    for (int i = 0; i < xlen; i++)
    {
        for (int j = 0; j < ylen; j++)
        {
            arr[i, j] = j + i;
        }
    }
    return arr;
}
// Вывод массива в терминал
void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int xlen = InputNum("Ваше число строк:");
int ylen = InputNum("Ваше число столбцов:");
int[,] matrix = CreateArray(xlen, ylen);
ShowArray(matrix);

