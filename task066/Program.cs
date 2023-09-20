/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

Console.WriteLine("Введите натуральное число M: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number > number1)
    {
        Console.WriteLine("Значение M должно быть меньше или равно N");
        return;
    }

int SumNumbers(int num, int num1)
{
    int sum = num;

    if (num == num1) return num;
    else
    {
        sum += SumNumbers(num + 1, num1);
    }
    return sum;
}

int sumNumbers = SumNumbers(number, number1);
Console.WriteLine(sumNumbers);