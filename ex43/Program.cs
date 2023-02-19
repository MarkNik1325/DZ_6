
double ReadInt (string argumentName)
{
Console.WriteLine($"Введите значение {argumentName}");
  int number = 0;

 while (!int.TryParse (Console.ReadLine(), out number))
 {
    Console.WriteLine("Its not number");
 }
 return number;
}

double FindCoordinateX (double k1, double k2, double b1, double b2)
{
double coordx = (b2 - b1)/(k1-k2);
return coordx;
}

double FindCoordinateY (double k1, double k2, double b1, double b2)
{
double coordy = (k1*b2 - k2*b1)/(k1-k2);
return coordy;
}

bool Validate (double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
        Console.WriteLine("Прямые совпадают"); 
        return false;
        }
    }
    else
    {
        Console.WriteLine("Прямые параллельны"); 
        return false;
    }
    return true;
}


double k1 = ReadInt ("k1");
double k2 = ReadInt ("k2");
double b1 = ReadInt ("b1");
double b2 = ReadInt ("b2");
Validate(k1, k2, b1, b2);
Console.WriteLine ($"Точки пересечения прямых y = {FindCoordinateY (k1, k2, b1, b2)}, x = {FindCoordinateX(k1, k2, b1, b2)}");