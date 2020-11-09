using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.Write("Give a number: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue > 0) 
{
        Console.WriteLine("It is positive.");
}

        else
{
        Console.WriteLine("It is not positive.");
}
    }
  }
}
