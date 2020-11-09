using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

    int sum = 0;
    int amount = 0;
 
while (true) 
{
    Console.WriteLine("Give a number");

    int input1 = Convert.ToInt32(Console.ReadLine());

    if (input1 == 0) 
    {
        Console.WriteLine("Total sum of numbers: " + sum + "\n" +
        "Total amount of numbers given: " + amount);
        break;
    }

    else
    {
        sum = (sum + input1);
        amount = (amount + 1);            
    }
   
    
}
    }
  }
}
