// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int evenSum = 0;
// Вывод результата в терминал
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
// Проверка на четность
bool Test(int n)
{
    return n % 2 == 0;
}
// Подсчет колич-ва четных чисел
void EvenSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i])) evenSum++;        
    }
}

int[] testArr = Gen1DArray(12, 100, 999);
EvenSum(testArr);
Print1DArr(testArr);
PrintData("Количество четных чисел в массиве: ", evenSum);

