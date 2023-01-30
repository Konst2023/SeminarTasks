// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int posSum = 0;
int negSum = 0;
// Вывод в терминал
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
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
// Раздельное суммирование отрицательных и положительных элементов массива
void NegPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)   
    {
        if (arr[i] > 0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
}

int[] testArr = Gen1DArray(12, -9, 9);
NegPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", posSum);
PrintData("Сумма отрицательных чисел в массиве: ", negSum);