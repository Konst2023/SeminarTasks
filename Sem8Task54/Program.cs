// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Ввод данных
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
// Сортировка массива построчно, по убыванию
void Sort2DArray(int[,] arr)
{
    int cols = arr.GetLength(1);
    int[] bufArr = new int[cols]; // буферный массив, длиной в кол-во столбцов
    for (int i = 0; i < arr.GetLength(0); i++) // по всем строкам
    {
        for (int k = 0; k < cols; k++)
        {
            bufArr[k] = arr[i, k]; // копируем построчно в буферный массив
        }
        Sort1DArray(bufArr); // отсортировали текущую строку по возрастанию
        for (int k = 0; k < cols; k++)
        {
            arr[i, k] = bufArr[k]; // копируем построчно из буферного массива
        }
    }
}
// Сортировка по убыванию
void Sort1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        // пробегаем по оставшейся части строки и ищем максимум
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;

        }
        // Обмен значениями текущего и максимального из оставшихся
        int temporary = array[i];    
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

int cols = ReadData("Строк: ");
int rows = ReadData("Столбцов: ");
int[,] arr = Gen2DArray(cols, rows, 9, 99);
Print2DArray(arr);
Sort2DArray(arr);
Print2DArray(arr);
