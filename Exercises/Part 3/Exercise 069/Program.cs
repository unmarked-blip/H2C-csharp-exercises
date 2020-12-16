using System;
using System.Collections.Generic;

namespace exercise_69
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

    Console.WriteLine("From where?");

    int start = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("To where?");

    int end = Convert.ToInt32(Console.ReadLine());

    while (start <= end)
                {
                    
                    if (list.Contains(start))

                        {
                            Console.WriteLine(start);
                        }   
                        
                    start = start + 1;
                }
                

    }
  }
}
