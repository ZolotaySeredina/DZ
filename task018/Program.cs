
string RangeCoordinates(int quarter)
{
    if (quarter == 1) return "x > 0 , y > 0";
    if (quarter == 2) return "x < 0 , y > 0";
    if (quarter == 3) return "x < 0 , y < 0";
    if (quarter == 4) return "x > 0 , y < 0";
    return null; 
}

Console.WriteLine("Введите номер четверти: ");
int Quarter = Convert.ToInt32(Console.ReadLine());

string rangeCoordinates = RangeCoordinates(Quarter);
string result = rangeCoordinates != null ? rangeCoordinates
                                         : "Введена некорретная четверть";
Console.WriteLine(result);                                        