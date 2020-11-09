using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {

    while (true) 
{
    Console.WriteLine("Give a number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    if (input1 == 0) 
    {
        break;
    }

    else if (input1 < 0)
    {
    Console.WriteLine("That is negative.");
    }

    else if (input1 > 0)
    {
    int power = Convert.ToInt32(input1 * input1);
    Console.WriteLine(power);
    }
    
}

    }
  }
}
