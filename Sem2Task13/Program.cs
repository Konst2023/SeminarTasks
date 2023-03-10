// Напишите программу, которая выводит третью цифру (слева) заданного числа 
// или сообщает, что третьей цифры нет.
// 13(3) 45(7)42 46(7)986564
// Приглашение
Console.Write("Введите число: ");
// Ввод числа
string? inpText = Console.ReadLine() ?? "0";
// Преобразование строки в массив символов
                                        // 012345678 - индексы массива                                      
char[] digits = inpText.ToCharArray(); // "467986564"
// Проверка числа на трех и более значность
if (digits.Length >= 3)
{
    Console.WriteLine("Третья цифра слева: " + digits[2]);
}
else
{
    Console.WriteLine("В числе меньше 3 цифр!");
}
