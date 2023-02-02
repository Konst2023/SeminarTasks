// Напишите программу, которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// Генератор одномерного массива для целых чисел
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}
// Распечатка одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Конвертация массива согласно условиям задачи
void ConvertArr(int[] arr)
{
    int tmpVar = 0;
    int arrLen = arr.Length;
    int newLen = arr.Length / 2; // Идем по половине массива без центрального
    for (int i = 0; i < newLen; i++)
    {
        // Перестановка значений [1, 2, 3]
        tmpVar = arr[i]; // tmp = 1
        arr[i] = arr[arrLen - 1 - i]; // arr[0] = 3
        arr[arrLen - 1 - i] = tmpVar; // arr[2] = 1
    }    
}

int[] testArr = Gen1DArray(5, 0, 100);
Print1DArr(testArr);
ConvertArr(testArr);
Print1DArr(testArr);
