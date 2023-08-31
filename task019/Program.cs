/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да */

bool check(int number)
{
    if (number < 0 || number < 10000 || number > 99999)
    {
        Console.WriteLine("Введены неверные данные");
        return false;
    }
    return true;
}

bool Palidrome(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num % 1000 / 1000;
    int thridDigit = num % 100 / 100;
    int fourthDigit = num % 10;
    return (firstDigit == fourthDigit && secondDigit == thridDigit);
}



Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (check(number))
{
    bool palidrome = Palidrome(number);
    Console.WriteLine(palidrome ? "Число является палидромом." : "Число не является палидромом.");
}








