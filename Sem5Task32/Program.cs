// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

// Генерация одномерного массива целых чисел
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
// Вывод в терминал одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Инвертируем массив
void InvArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1; // arr[i] = arr[i] * (-1);
    }
}

int[] testArr = Gen1DArray(12, -9, 9);
Print1DArr(testArr);
InvArr(testArr);
Print1DArr(testArr);

