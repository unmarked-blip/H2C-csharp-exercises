using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.Write("Give your age: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue < 1900) 
{
    Console.WriteLine("You're old.");
}

    }
  }
}
