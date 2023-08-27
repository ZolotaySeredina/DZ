
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int numberF(int number)
{
while (number > 999)
number /= 10;
return number % 10;
}

bool check(int number)
{
if (number<100)
return false;
else return true;
}
if (check(number) != true)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа {number} является {numberF(number)}");
