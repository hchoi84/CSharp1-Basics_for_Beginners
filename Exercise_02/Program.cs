using System;

namespace Exercise_02
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
      string[] inputArr;
      int max;

      Console.WriteLine("Enter a series of numbers separated by comma (i.e. 1, 2, 3, 4)");
      inputArr = Console.ReadLine().Split(',');
      max = Convert.ToInt32(inputArr[0]);

      foreach (string s in inputArr)
      {
        if (max < Convert.ToInt32(s))
          max = Convert.ToInt32(s);
      }

      Console.WriteLine(max);
    }

    private static void Four()
    {
      int rand = new Random().Next(1, 11);
      int guessChance = 4;

      Console.WriteLine("Guess what number I chose: ");

      while (guessChance > 0)
      {
        Console.WriteLine("{0} chances remaining", guessChance);
        if (Convert.ToInt32(Console.ReadLine()) == rand)
        {
          Console.WriteLine("You Won!!");
          break;
        }
        
        if (guessChance-- > 1)
          Console.WriteLine("Guess again");
      }

      if (guessChance == 0)
        Console.WriteLine("You Lost!!");
    }

    private static void Three()
    {
      int factorial = 1, input = 0;

      Console.WriteLine("Please enter a number: ");
      input = Convert.ToInt32(Console.ReadLine());

      for (int i = input; i > 0; i--)
      {
        factorial *= i;
      }

      Console.WriteLine("{0}! = {1}", input, factorial);
    }

    private static void Two()
    {
      int sum = 0;

      while (true)
      {
        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine();
        if (input == "ok")
          break;

        sum += Convert.ToInt32(input);
        Console.WriteLine("Current sum is " + sum);
      }
    }

    private static void One()
    {
      Console.WriteLine(100 / 3);
    }
  }
}
