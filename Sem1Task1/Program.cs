// Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число 
// квадратом второго.
// Запрашиваем ввести число у пользователя
Console.Write("Введите число (квадрат второго): ");
// Считываем число
string? inputNum1 = Console.ReadLine();
// Запрашиваем ввести число у пользователя
Console.Write("Введите число: ");
// Считываем число
string? inputNum2 = Console.ReadLine();
// Проверка на не равенство null
if (inputNum1 != null && inputNum2 != null)
{
    // Преобразуем строку в целое число
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    // Проверяем является ли число1 квадратом числа2
    if (number1 == number2 * number2)
    {
        // Да, является
        Console.WriteLine("Да");
    }
    else
    {
        // Нет, не является
        Console.WriteLine("Нет");
    }
}
