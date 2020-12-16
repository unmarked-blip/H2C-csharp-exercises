using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

    Console.WriteLine("Search for number:");
    
    int input1 = Convert.ToInt32(Console.ReadLine());

    int index = list.IndexOf(input1);

        for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                        
                    if (input1 == number)
                        {
                            Console.WriteLine(input1 + " is at index: " + i);
                        }
            }
        
    }
  }
}
