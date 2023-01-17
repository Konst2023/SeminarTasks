// Напишите программу, которая будет выдавать название 
// дня недели по заданному номеру.
// Запрашиваем ввести число у пользователя
Console.Write("Введите номер дня недели: ");
// Считываем число
string? inputNum = Console.ReadLine();
// Проверка на не равенство null
if (inputNum != null)
{
    // Преобразуем строку в целое число
    int inputNumber = int.Parse(inputNum);
    // Вариант 2:
    // Задаем пустую строку
    string outDayOfWeek = string.Empty;
    // Используем переключатель с соотв. значением...
    switch (inputNumber)
    {
        case 1: outDayOfWeek = "Monday"; break;
        case 2: outDayOfWeek = "Tuesday"; break;
        case 3: outDayOfWeek = "Wednesday"; break;
        case 4: outDayOfWeek = "Thursday"; break;
        case 5: outDayOfWeek = "Friday"; break;
        case 6: outDayOfWeek = "Saturday"; break;
        case 7: outDayOfWeek = "Sunday"; break;
        default: outDayOfWeek = "Not a Week Day"; break;
    }
    // Вывод результата
    Console.WriteLine(outDayOfWeek);
}
