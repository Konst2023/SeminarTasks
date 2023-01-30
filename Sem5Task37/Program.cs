// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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
// Перемножение элементов массива симметричных относительно середины массива
int[] MultiplyArr(int[] arr)
{
    int[] newArr = new int[(arr.Length / 2) + arr.Length % 2]; // old = 10 -> new = 5; old = 11 -> new = 6
    int arrLen = arr.Length; // длина исходного массива
    // 1 2 3 4 5 6 - old четн
    // 7 7 7   - new

    // 1 2 3 4 5 6 7 - old нечетн
    // 8 8 8 8  - new

    for (int i = 0; i < newArr.Length; i++) 
    {
        newArr[i] = arr[i] * arr[arrLen - 1 - i]; // текущий эл-т + симметричный ему отн. середины
    }
    return newArr;
}

int[] testArr = Gen1DArray(5, 0, 100);
Print1DArr(testArr);
int[] cnvArr = MultiplyArr(testArr);
Print1DArr(cnvArr);
// Print1DArr(testArr);
