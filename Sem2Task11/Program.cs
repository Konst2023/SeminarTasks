// У трехзначного числа распечатать первую и последнюю цифру

// System.Random newSintezator = new System.Random();
// int num = newSintezator.Next(100, 1000);
// Console.WriteLine("число: " + num);

// int digitfirst = num / 100;
// int digitLast = num % 10;
// Console.WriteLine(digitfirst * 10 + digitLast);

// вариант 2
System.Random random = new System.Random();
int randomNumber = random.Next(100, 1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();
char[] numberArray = value.ToCharArray();
Console.WriteLine(numberArray[0] + ":" + numberArray[2]);
