// Проверить введенное число на кратность 7 и 23

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

if (( num1 % 7 == 0) && (num1 % 23 == 0))  // Логическое И: &&, логическое ИЛИ: || 
{
    Console.Write("Число кратно 7 и 23");
}
else
{
    Console.Write("Число не кратно 7 и 23");
}
