﻿using System;
using System.Collections.Generic;

namespace exercise_68
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

      int index = 0;

      while (index < list.Count)
                {
                    Console.WriteLine(list[index]);
                    index = index + 1;
                }

    }
  }
}
