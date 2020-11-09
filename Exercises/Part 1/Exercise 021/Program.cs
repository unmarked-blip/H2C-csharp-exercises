using System;

namespace exercise_21
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

    double average = (firstValue + secondValue) / 2.0 ;

    Console.WriteLine("The average for the numbers is " + average);

    }
  }
}
