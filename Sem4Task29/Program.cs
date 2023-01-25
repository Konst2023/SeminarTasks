// 29) Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// * Ввести с клавиатуры длину массива и диапазон значений элементов  
//  *Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал 
// Игорь, Антон, Сергей -> Антон 

// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Ask1DArr(int num)
{    
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Элемент " + i + " = ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");

int[] arr = Ask1DArr(arrLen);

Print1DArr(arr);
