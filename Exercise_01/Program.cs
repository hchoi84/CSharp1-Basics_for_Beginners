using System;

namespace Mosh
{
  class Program
  {
    static void Main(string[] args)
    {
      // Exercise1();
      // Exercise2();
      // Exercise3();
      Exercise4();
    }

    private static void Exercise4()
    {
      int speedLimit, carSpeed, demeritPoint;

      Console.WriteLine("What is the Speed Limit?");
      speedLimit = Int32.Parse(Console.ReadLine());

      Console.WriteLine("What is the Speed of the passing car?");
      carSpeed = Int32.Parse(Console.ReadLine());

      demeritPoint = (carSpeed - speedLimit) / 5;

      if (carSpeed < speedLimit)
        Console.WriteLine("Ok");
      else if (demeritPoint < 0)
        Console.WriteLine("Whoa~ almost got a point!");
      else if (demeritPoint < 12)
        Console.WriteLine(demeritPoint + " demerit points earned!");
      else
        Console.WriteLine("License suspended!");
    }

    private static void Exercise3()
    {
      int[] resolution = new int[2];

      Console.WriteLine("First Number?");
      resolution[0] = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Second Number?");
      resolution[1] = Int32.Parse(Console.ReadLine());

      Console.WriteLine(resolution[0] > resolution[1] ? resolution[0] : resolution[1]);
    }

    public static void Exercise2()
    {
      int[] resolution = new int[2];

      Console.WriteLine("Width?");
      resolution[0] = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Height?");
      resolution[1] = Int32.Parse(Console.ReadLine());

      Console.WriteLine(resolution[0] > resolution[1] ? "landscape" : "portrait");
    }

    public static void Exercise1()
    {
      Console.WriteLine("Please enter a number between 1 and 10");
      string valueEntered = Console.ReadLine();
      int valueEnteredToInt = Int32.Parse(valueEntered);
      
      Console.WriteLine(valueEnteredToInt >= 1 && valueEnteredToInt <= 10 ? "Valid" : "Invalid");
    }
  }
}
