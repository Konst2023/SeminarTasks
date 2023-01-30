// Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массив
// Запрос искомого числа
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Ввод результата
void PrintData(string res)
{
    Console.WriteLine(res);
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
// Поиск введенного числа в одномерном массиве
int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}

int[] testArr = Gen1DArray(12, -9, 9);
Print1DArr(testArr);
int element = ReadData("Какой элемент найти?: ");
int result = SearchElem(testArr, element);  // Если да, то полож. число, если нет, то -1

if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("Элемент в массиве не найден.");
}
