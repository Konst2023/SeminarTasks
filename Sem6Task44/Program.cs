// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Числа Фибоначчи
// f(1) = 1; f(2) = 1; f(n) = f(n-1) + f(n-2)

// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Вычисление чисел фибоначчи в массиве
double[] Fibonacci(int n)
{
    double[] fbn = new double[n];

    for (int i = 0; i < n; i++)
    {
        if (i == 0 || i == 1) fbn[i] = 1.0;
        else
        {
            fbn[i] = fbn[i - 1] + fbn[i - 2];
        }
    }

    return fbn;
}
// Выводим одномерный массив вещественных чисел
void Print1DDblArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(String.Format("{0:f0}", arr[i]) + ", ");
    }
    Console.WriteLine(String.Format("{0:f0}", arr[arr.Length - 1]) + "]");
}

int n = ReadData("Введите число: ");
Print1DDblArr(Fibonacci(n));
