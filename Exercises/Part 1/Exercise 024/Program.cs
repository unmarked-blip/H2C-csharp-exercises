using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Enter your speed: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber);

        if (firstValue > 125) 
{
    Console.WriteLine("Your speed: \n"
        + firstValue + "\n"
        + "Speeding!");
}
      
    }
  }
}
