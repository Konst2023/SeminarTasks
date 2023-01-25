//Задача №30
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке. [0, 0, 1, 1, 0, 1, 1, 0]

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num]; // 0, 1, 2, ...
    for (int i = 0; i < arr.Length; i++)
    {
        // Правая граница не входит! Использовать NextDouble для double
        arr[i] = rnd.Next(begin, end + 1); // [begin; end)
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("["); // [0, 0, 1, 1, 0, 1, 1, 0]
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");

int[] arr = Gen1DArr(arrLen, 0, 1);

Print1DArr(arr);