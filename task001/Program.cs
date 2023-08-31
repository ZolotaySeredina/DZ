using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапозона 100-999 -> {number} ");

int firstDigit = number / 100;
int lastDigit = number % 10;
int result = firstDigit * 10 + lastDigit;
Console.WriteLine(result);

int TwoNumbers(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}
int twoNumbers = TwoNumbers(number);
Console.WriteLine(twoNumbers);
