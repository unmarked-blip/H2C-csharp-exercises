using System;

namespace exercise_38
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
        Console.WriteLine("Total amount of negative numbers: " + sum);
        break;
    }

    else if (input1 < 0)
    {
        sum = (sum + 1);
    }

   
    
}


    }
  }
}
