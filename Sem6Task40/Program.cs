// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Алгоритм:
// Найти максимальное значение
// Проверить, что сумма остальных меньше максимального

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1)
{
    Console.WriteLine(msg1);
}
// Проверка условия существования треугольника
bool CheckTriangle(int x, int y, int z)
{
    // проверяем сумму
    if (x < y + z && y < x + z && z < x + y) return true;    
    else return false;
}
// 
int var1 = ReadData("Введите 1-е число: "); 
int var2 = ReadData("Введите 2-е число: ");
int var3 = ReadData("Введите 3-е число: ");

bool answer = CheckTriangle(var1, var2, var3);
if (answer) 
    PrintData("Да может");
else 
    PrintData("Нет, не может");


