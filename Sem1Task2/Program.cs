// Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее

// Алгоритм:
// Считать 2 числа (строки)
// Преобразовать в целые числа
// Сравнить 2 числа
// Вывести результат

// Запрашиваем число 1 у пользователя
Console.Write("Ведите число: ");
// Считываем число
string? strNum1 = Console.ReadLine();
// Запрашиваем число 2 у пользователя
Console.Write("Ведите число: ");
// Считываем число
string? strNum2 = Console.ReadLine();
// Проверка на не равенство null

if (strNum1 != null && strNum2 != null)
{
    // Преобразуем строку в целое число
    int intNum1 = int.Parse(strNum1);
    int intNum2 = int.Parse(strNum2);
    // Проверяем условие и выводим результат
    if (intNum1 > intNum2) {Console.WriteLine("Число " + intNum1 + " > " + "числа " + intNum2);}
    else { Console.WriteLine("Число " + intNum2 + " > " + "числа " + intNum1); }

}