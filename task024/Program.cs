int SumNumbers (int num) 
{
int sum = 0;
for (int i = 0; i < num; i++)
{
   sum += i;
}
return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");