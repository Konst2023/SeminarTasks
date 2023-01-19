
// Является ли число 1 кратным числу 2
Console.Write("Введите 1-е число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0"); // альтернатива проверки на null!!!
Console.Write("Введите 2-е число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int result = num1 % num2;
if (result == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Не кратно, остаток " + result);
}
