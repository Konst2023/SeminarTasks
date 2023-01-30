// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int oddSum = 0;
// Вывод значения в терминал
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
        arr[i] = new Random().Next(minValue, maxValue + 1);
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
// Рационализируем код
void OddSum(int[] arr)
{   // Идем через 1 только по нечетным (четным при нумерации с 0)
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        oddSum += arr[i];
    }
}

int[] testArr = Gen1DArray(5, 1, 10);
OddSum(testArr);
Print1DArr(testArr);
PrintData("Сумма нечетных элементов в массиве: ", oddSum);

