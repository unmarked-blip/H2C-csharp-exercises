using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

    int sum = 0;
    int amount = 0;
    int evenNumbers = 0;
    int oddNumbers = 0;
 
    Console.WriteLine("Give numbers: ");

while (true) 
{
    int input1 = Convert.ToInt32(Console.ReadLine());

    if (input1 == -1) 
    {
        double mean = ((double)sum / (double)amount);
        Console.WriteLine("Thx! bye! \n" + 
        "Total sum of numbers: " + sum + "\n" +
        "Numbers: " + amount + "\n" + 
        "Average: " + mean + "\n" +
        "Even: " + evenNumbers + "\n" +
        "Odd: " + oddNumbers);
        break;
    }

    else
    {
        sum = (sum + input1);
        amount = (amount + 1);
                    if (input1%2 == 0) 
                    {
                        evenNumbers = (evenNumbers + 1);
                    }
                    else
                    {
                        oddNumbers = (oddNumbers + 1);
                    }
    }
 
}
    }
  }
}
