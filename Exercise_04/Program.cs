using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_04
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

    #region One
    private static void One()
    {
      string[] separatedInput;

      Console.WriteLine("This app will determine if the numbers are consecutive");
      Console.WriteLine("Please enter the numbers separated by a hyphen: ");

      while (true)
      {
        if (!IsValidInput(out separatedInput))
          break;

        Console.WriteLine("Must contain more than 2 numbers");
        Console.WriteLine();
      }

      Console.WriteLine(IsConsecutive(separatedInput) ? "Consecutive" : "Not Consecutive");
    }

    public static bool IsValidInput(out string[] separatedInput)
    {
      string input = Console.ReadLine();
      separatedInput = input.Split('-');

      if (separatedInput.Length > 2)
        return false;
      return true;
    }

    public static bool IsConsecutive(string[] separatedInput)
    {
      int[] nums = Array.ConvertAll(separatedInput, Convert.ToInt32);
      int diffChecker = nums[1] - nums[0];

      if (diffChecker != -1 && diffChecker != 1)
        return false;
      else
      {
        for (var i = 2; i < nums.Length; i++)
        {
          if (nums[i] - nums[i - 1] != diffChecker)
            return false;
        }
      }

      return true;
    }
    #endregion

    #region Two
    private static void Two()
    {
      string[] separatedInput;
      List<int> nums = new List<int>();

      Console.WriteLine("This app will determine if there are duplicate numbers.");
      Console.WriteLine("Please enter the numbers separated by a hyphen: ");

      while (true)
      {
        if (!IsValidInput(out separatedInput))
          break;

        Console.WriteLine("Must contain more than 2 numbers");
        Console.WriteLine();
      }

      Console.WriteLine(HasDuplicates(separatedInput, nums) ? "Has Duplicates" : "No Duplicates");
    }

    private static bool HasDuplicates(string[] separatedInput, List<int> nums)
    {
      int[] numsArr = Array.ConvertAll(separatedInput, Convert.ToInt32);

      foreach (int num in numsArr)
      {
        if (nums.Contains(num))
          return true;

        nums.Add(num);
      }

      return false;
    }
    #endregion

    #region Three
    private static void Three()
    {
      DateTime inputDt = new DateTime();

      Console.WriteLine("Please enter a time value in military format (16:30)");
      string input = Console.ReadLine();

      try
      {
        inputDt = Convert.ToDateTime(input);
        Console.WriteLine("Ok");
      }
      catch
      {
        Console.WriteLine("Invalid");
      }
    }
    #endregion

    #region Four
    private static void Four()
    {
      string input;

      Console.WriteLine("This app will convert a sentence to PascalCase");
      input = Console.ReadLine().ToLower();

      Console.WriteLine(GenerateOutput(input));
    }

    private static StringBuilder GenerateOutput(string input)
    {
      StringBuilder output = new StringBuilder();

      foreach (string s in input.Split(" "))
      {
        StringBuilder temp = new StringBuilder();
        temp.Append(s).Replace(temp[0], char.ToUpper(temp[0]));

        output.Append(temp);
      }

      return output;
    }
    #endregion

    #region Five
    private static void Five()
    {
      string input;

      Console.WriteLine("This app will determine how many vowels there are in a word");
      Console.WriteLine("Please enter a word: ");
      
      input = Console.ReadLine().ToLower();

      Console.WriteLine($"There are {CountVowels(input)} vowels");
    }

    private static int CountVowels(string input)
    {
      List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
      int vowelCount = 0;

      foreach (char letter in input)
      {
        if (vowels.Contains(letter))
          vowelCount++;
      }

      return vowelCount;
    }
    #endregion
  }
}
