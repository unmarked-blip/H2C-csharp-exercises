using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give a number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Give the second number");

    int input2 = Convert.ToInt32(Console.ReadLine());

    double squareRoot = Math.Sqrt(input1 + input2);

    Console.WriteLine(squareRoot);
    
    }
  }
}
