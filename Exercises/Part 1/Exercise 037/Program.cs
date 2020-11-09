using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
 
while (true) 
{
    Console.WriteLine("Give a number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    if (input1 == 0) 
    {
        Console.WriteLine("Total amount of numbers: " + sum);
        break;
    }

    else 
    {
        sum = (sum + 1);
    }

   
    
}

    }
  }
}
