// Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число умноженное на 
// само себя).
// Запрашиваем ввести число у пользователя
Console.Write("Введите число: ");
// Считываем число
string? inputNum = Console.ReadLine(); // ? означает проверку на Null
// Проверка на не равенство null
if (inputNum != null)
{
    // Преобразуем строку в целое число
    int number = int.Parse(inputNum);
    // Перемножаем число на себя
    int result = number * number;
    // Второй способ
    // int result = (int)Math.Pow(number, 2);
    // Задаем красиывый вывод
    Console.Write("Квадрат числа равен: ");
    // Выводим полученное число
    Console.WriteLine(result);    
}