// Напишите программу, которая будет создавать копию заданного одномерного массива 
// с помощью поэлементного копирования.

// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Генерация одномерного массива длины кот. указал пользователь
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// Создание копии массива
int[] Copy1DArray(int[] inputArr)
{
    int len = inputArr.Length;
    int[] outputArr = new int[len];
    for (int i = 0; i < len; i++) outputArr[i] = inputArr[i];    
    return outputArr;
}
// Печать одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");

}

int n = ReadData("Введите длину массива: ");
int[] arr1 = Gen1DArray(n, 10, 100);
Print1DArr(arr1);
int[] arr2 = Copy1DArray(arr1);
Print1DArr(arr2);
