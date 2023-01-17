//  Напишите программу, которая принимает на вход три числа и
//  выдаёт максимальное из этих чисел

// Алгоритм:
// Считать 3 числа (строки)
// Преобразовать в целые числа
// Сравнить 3 числа
// Вывести результат

// Запрашиваем число 1 у пользователя
Console.Write("Ведите 1 число: ");
// Считываем число
string? strNum1 = Console.ReadLine();
// Запрашиваем число 2 у пользователя
Console.Write("Ведите 2 число: ");
// Считываем число
string? strNum2 = Console.ReadLine();
// Запрашиваем число 2 у пользователя
Console.Write("Ведите 3 число: ");
// Считываем число
string? strNum3 = Console.ReadLine();

// Проверка на не равенство null

if (strNum1 != null && strNum2 != null && strNum3 != null)
{
    // Преобразуем строку в целое число
    int intNum1 = int.Parse(strNum1); // 5 3 8 ->  -> (3 > 8)
    int intNum2 = int.Parse(strNum2);
    int intNum3 = int.Parse(strNum3);
    // Проверяем условие и выводим результат
    if (intNum1 > intNum2 && intNum1 > intNum3)  // (5 > 3 && 5 > 8)
    {
        Console.WriteLine("max =  " + intNum1);
    }
    else
    {
        if (intNum2 > intNum3) 
        {
            Console.WriteLine("max =  " + intNum2);
        }
        else
        {
            Console.WriteLine("max =  " + intNum3);
        }
    }
   

}