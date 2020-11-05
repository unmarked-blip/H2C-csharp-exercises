using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Give first number: ");

    string firstNumber = Console.ReadLine();

    int firstValue = Convert.ToInt32(firstNumber); 

    Console.Write("Give second number: ");

    string secondNumber = Console.ReadLine();

    int secondValue = Convert.ToInt32(secondNumber); 

    Console.Write("Give third number: ");

    string thirdNumber = Console.ReadLine();

    int thirdValue = Convert.ToInt32(thirdNumber); 

    int sum = firstValue + secondValue + thirdValue;

    Console.WriteLine("The sum is " + sum);

    }
  }
}
