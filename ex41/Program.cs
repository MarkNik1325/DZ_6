int ReadInt (string argumentName)
{
Console.WriteLine($"Введите колличество чисел в массиве {argumentName}");
  int number = 0;

 while (!int.TryParse (Console.ReadLine(), out number))
 {
    Console.WriteLine("Its not number");
 }
 return number;
}

void RandomArray (int[] array)
 {
    Random random = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array [i] = random.Next(-10, 11);
    }
 }

int FindPositive (int [] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] >0)
        {
        sum++;
        }
    }
    return sum;
}

int number = ReadInt ("");
int [] array = new  int[number];
RandomArray (array);
Console.WriteLine (string.Join(" ", array));
Console.WriteLine ($"Колличество чисел больше нуля равняется {FindPositive (array)}");
