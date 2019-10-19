using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_05
{
  class Program
  {
    static void Main(string[] args)
    {
      // One();
      EnumTest();
    }

    [Flags]
    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };
    static void EnumTest()
    {
      Console.WriteLine("The entries of the Colors enumeration are:");
      foreach (string colorName in Enum.GetNames(typeof(Colors)))
      {
        Console.WriteLine("{0} = {1:D}", colorName, Enum.Parse(typeof(Colors), colorName));
      }
      Console.WriteLine();

      Colors orange = (Colors) Enum.Parse(typeof(Colors), "Green, Blue, Yellow");
      Console.WriteLine("The orange value {0:D} has the combined entries of {0}", orange);
      // Without [Flags], the console won't list the colors Green, Blue, Yellow
    }

    static void One()
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      string fileName = "SampleFile.txt";
      string fileContent = File.ReadAllText(Path.Join(currentDirectory, "/", fileName));
      List<string> fileContentList = fileContent.Split(new Char[] {' ', '.'}).ToList();
      string longestWord = "";
      
      Console.WriteLine($"The file has {fileContentList.Count} words");

      foreach (var word in fileContentList)
      {
        if (word.Length > longestWord.Length)
          longestWord = word;
      }

      Console.WriteLine($"The longest word is \"{longestWord}\"");
    }
  }
}
