using System;
using System.Collections.Generic;

namespace Exercise_03
{
  class Program
  {
    static void Main(string[] args)
    {
      // One();
      // Two();
      // Three();
      // Four();
      Five();
    }

    private static void Five()
    {
      string[] input;

      Console.WriteLine("Please enter at least 5 comma separated numbers. (i.e. 1, 5, 6, 8, 4, 5)");

      while (true)
      {      
        input = Console.ReadLine().Split(',');

        if (input.Length < 5)
        {
          Console.WriteLine("Not enough data. Must have at least 5 numbers");
          continue;
        }

        break;
      }

      int[] nums = Array.ConvertAll(input, int.Parse);
      Array.Sort(nums);
      Array.Resize(ref nums, 3);
      foreach (int n in nums)
        Console.WriteLine(n);
    }

    private static void Four()
    {
      List<int> nums = new List<int>();

      Console.WriteLine("Enter numbers. When done, type \"Quit\"");

      while (true)
      {
        string input = Console.ReadLine();

        if (input == "Quit")
          break;

        if (nums.Contains(Convert.ToInt32(input)))
          continue;

        nums.Add(Convert.ToInt32(input));
      }

      foreach (int num in nums)
      {
        Console.Write(num);
      }
    }

    private static void Three()
    {
      List<int> nums = new List<int>();

      Console.WriteLine("Please enter 5 numbers");

      while (nums.Count < 5)
      {
        int num = Convert.ToInt32(Console.ReadLine());
        if (nums.Contains(num))
        {
          Console.WriteLine("That number already exists. Please enter another number");
          continue;
        }
        nums.Add(num);
      }

      nums.Sort();
      foreach (int num in nums)
      {
        Console.Write(num);
      }
    }

    private static void Two()
    {
      Console.WriteLine("Please enter your name: ");
      char[] letters = Console.ReadLine().ToCharArray();
      Array.Reverse(letters);
      string reversedName = String.Join("", letters);
      Console.WriteLine(reversedName);
    }

    private static void One()
    {
      List<string> names = new List<string>();
      
      Console.WriteLine("Enter names. When done hit ENTER");

      while (true)
      {
        string input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
          break;
        else
          names.Add(input);
      }

      Console.WriteLine("{0}{1}", String.Join(", ", names.ToArray(), 0, 2), names.Count > 2 ? " and " + (names.Count - 2) + " more" : "");
    }
  }
}
