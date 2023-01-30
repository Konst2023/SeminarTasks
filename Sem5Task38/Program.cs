// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементом массива
// Вывод вещественного результата
void PrintDblData(string res, double value)
{
    Console.WriteLine(res + String.Format("{0:f4}", value));
}

// Генерация одномерного массива вещественных чисел
double[] Gen1DDblArray(int len, double minDbl, double maxDbl)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble(); // Случайное вещественное в интервале (0, 1)
        arr[i] = minDbl + arr[i] * (maxDbl - minDbl); // Растягиваем интервал до (min, max)
    }
    return arr;
}
// Вывод в терминал одномерного вещественного массива
void Print1DDblArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(String.Format("{0:f4}", arr[i])  + ", ");
    }
    Console.WriteLine(String.Format("{0:f4}", arr[arr.Length - 1])  + "]");
}
// Разница между мин и макс значениями массива
double Diff(double[] arr)
{   double minValue = double.MaxValue;
    double maxValue = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minValue) minValue = arr[i];
        if (arr[i] > maxValue) maxValue = arr[i];
    }
    return maxValue - minValue;
}

double[] testArr = Gen1DDblArray(5, 1.0, 10.0);
Print1DDblArr(testArr);
PrintDblData("Разница между максимальным и минимальным элементом массива: ", Diff(testArr));

