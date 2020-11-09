using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give the first number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Give a second number");

    int input2 = Convert.ToInt32(Console.ReadLine());

    if (input1 < input2)
    {
        Console.WriteLine(input1 + " is less than " + input2);
    }

    else if  (input1 > input2)
    {
        Console.WriteLine(input1 + " is grEater than " + input2);
    }

    else if (input1 == input2)
    {
        Console.WriteLine(input1 + " is equal to " + input2);        
    }

    }
  }
}
