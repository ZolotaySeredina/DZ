int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число");
if (number >=100 && number <1000)
{
int mid = (number % 100 - number % 10) / 10;
System.Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
System.Console.WriteLine("Это число не трехзначное");