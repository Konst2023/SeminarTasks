// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Ввод данных пользователем в массив 
int[] ReadNumbers(string msg, int n)
{
    int[] numbers = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write(msg);
        numbers[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return numbers;
}
// Подсчет положительных чисел массива
int CountNumbers(int[] numbers)
{
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0) counter++;
    }
    return counter;
}
// Вывод одномерного целого массива в терминал
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Вывод сообщения 
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Количество чисел для ввода: ");
int[] numParsed = ReadNumbers("Введите число: ", n);
Print1DArr(numParsed);
int count = CountNumbers(numParsed);
PrintData("Введено " + count + " положительных чисел.");
