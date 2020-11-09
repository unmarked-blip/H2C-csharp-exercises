using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
   
    Console.Write("Give a number: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue%2 == 0) 
{
        Console.WriteLine("It is even.");
}
        else
{
        Console.WriteLine("It is odd.");
}

    }
  }
}
