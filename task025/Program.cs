/* Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Numeral(int num, int deg)
{
    int sum = num;

    for (int i = 1; i < deg; i++)
    {
        sum = sum * num;
    }
    return sum;
}

bool check(int deg)
{
    if (deg < 0) 
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень");
int degree = Convert.ToInt32(Console.ReadLine());

if (check(degree))
{
int result = Numeral(number, degree);
Console.WriteLine($"Число {number} в степени {degree} является -> {result}");
}