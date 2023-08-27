using System.Globalization;

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoDigit(num, 7, 23);
Console.WriteLine(result? "Да" : "Нет");

bool MultiplicityTwoDigit(int numb, int numb1, int numb2)
{
    return numb % numb1 == 0 && numb % numb2 == 0;
}