﻿// Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые 
// числа в промежутке от -N до N (-3, -2, -1, 0, 1, 2, 3)
// Запрашиваем число у пользователя
Console.Write("Введите число: ");
// Считываем число
string? strNum = Console.ReadLine();
// Проверка на не равенство null
if (strNum != null)
{
    // Преобразуем строку в целое число
    int intNum1 = int.Parse(strNum);
    // Вычисляем обратное число
    int intNum2 = intNum1 * (-1);
    // Задаем пустую строку для записи ответа
    string strOut = string.Empty;
    // Цикл от меньшего до крайнего справа не включая
    while(intNum2 < intNum1)
    {
        // Собираем в строку значения от минимального, разделяя (,)
        strOut = strOut + intNum2 + ",";
        // Переходим к следующему числу
        intNum2 = intNum2 + 1;
    }
    // Вывод до последнего не включая
    Console.Write(strOut);
    // Вывод последнего числа
    Console.WriteLine(intNum1);
}