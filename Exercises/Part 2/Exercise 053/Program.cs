using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
        Console.WriteLine("Give the first number: ");

        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give the second number: ");

        int input2 = Convert.ToInt32(Console.ReadLine());

        DivisionOfNumbers(input1,input2);

    }

    public static void DivisionOfNumbers(double input1, double input2) 
    {
            
            Console.WriteLine("When divided the number is: " + (input1 / input2));

            
            
    }

  }
}
