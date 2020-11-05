using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.Write("Give a string: ");

    string words = Console.ReadLine();

    Console.Write("Give a integer: ");

    string integer = Console.ReadLine();
            
    int intValue = Convert.ToInt32(integer);

    Console.Write("Give a double: ");

    string userDouble = Console.ReadLine();

    double doubleValue = Convert.ToDouble(userDouble);

    Console.Write("Give a boolean: ");

    string userBoolean = Console.ReadLine();

    bool booleanValue = System.Convert.ToBoolean(userBoolean);
            
        
    Console.WriteLine("Your string: " + words + "\n" + 
        "Your integer: " + intValue + "\n" + 
        "Your double: " + doubleValue + "\n" +
        "Your boolean: " + booleanValue);

    }
  }
}
