// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Заполняем 3D массив уникальными случайными числами
int[,,] Gen3DArray(int x, int y, int z, int min, int max)
{
    int[,,] matr = new int[x, y, z];
    Random rnd = new Random();
    string allNumbers = string.Empty;
    int rndNumber = 0;    

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            int k = 0;
            while (k < z)
            {
                rndNumber = rnd.Next(min, max + 1); // случайное число
                if (allNumbers.Contains(rndNumber.ToString()) == false) // если не было
                {
                    allNumbers = allNumbers + rndNumber + ", "; // добавляем в строку использованных
                    matr[i, j, k] = rndNumber;                    
                    k++; // переходим к следующему
                }                
            }
        }
    }
    return matr;
}
// Печать трехмерного массива с индексами
void Print3DArrayWithIndex(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }        
    }
    Console.WriteLine();
}

int x = ReadData("Введите размерность x 3-х мерного массива: ");
int y = ReadData("Введите размерность y 3-х мерного массива: ");
int z = ReadData("Введите размерность z 3-х мерного массива: ");
int[,,] arr =  Gen3DArray(x, y, z, 10, 99);
Print3DArrayWithIndex(arr);