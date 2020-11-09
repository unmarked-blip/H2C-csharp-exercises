using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give a number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    if (input1 < 0)
    {
        int input2 = (input1 * (-1));
        Console.WriteLine(input2);
                    
    }

    else

    Console.WriteLine(input1);
      
    }
  }
}
