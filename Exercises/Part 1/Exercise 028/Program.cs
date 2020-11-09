using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.Write("How old are you? ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue >= 18) 
{
        Console.WriteLine("You're an adult.");
}

        else
{
        Console.WriteLine("You're underage.");
}

    }
  }
}
