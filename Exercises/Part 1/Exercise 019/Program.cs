using System;

namespace exercise_19
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

    int sum = firstValue + secondValue;

    Console.WriteLine("The sum is " + firstValue + " + " + secondValue + " = " + sum);

    }
  }
}
