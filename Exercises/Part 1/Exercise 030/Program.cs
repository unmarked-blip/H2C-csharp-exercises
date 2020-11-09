using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.Write("Give your percent [0 - 100]: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue < 0) 
{
        Console.WriteLine("Impossible!");
}

        else if (firstValue <= 49)
{
        Console.WriteLine("Fail");
}

        else if (firstValue <= 59)
{
        Console.WriteLine("1");
}

        else if (firstValue <= 69)
{
        Console.WriteLine("2");
}

        else if (firstValue <= 79)
{
        Console.WriteLine("3");
}

        else if (firstValue <= 89)
{
        Console.WriteLine("4");
}

        else if (firstValue <= 100)
{
        Console.WriteLine("5");
}

        else
{
        Console.WriteLine("Outstanding!");
}
    }
  }
}
