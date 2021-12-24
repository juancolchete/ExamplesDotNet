using System;
using System.Threading;

namespace xmas
{
  class Program
  {
    public static void mountTree(int minRemove, int maxRemove) 
    {
      for (int i = 0; i < 8; i++)
      {
        writeSpaces(minRemove);
        writeasterisk(maxRemove - minRemove);
        writeSpaces(minRemove);
        minRemove--;
        maxRemove++;
        Console.Write("\n");
      }
    }
    public static void mountLog(int spaces,int logHeight, int logSize) 
    {
      for (int i = 0; i < logHeight; i++)
      {
        writeSpaces(spaces);
        writeasterisk(logSize);
        writeSpaces(spaces);
        Console.Write("\n");
      }
    }
    public static void mountPot(int minRemove, int maxRemove) 
    {
      for (int i = 0; i < 2; i++)
      {
        writeSpaces(minRemove);
        writeasterisk(maxRemove - minRemove);
        writeSpaces(minRemove);
        minRemove++;
        maxRemove--;
        Console.Write("\n");
      }
     }
    public static void sendMerryXmas() {
      writeSpaces(4);
      Console.Write("MERRY CHRISTMAS!!!");
    }
    public static void writeSpaces(int spaces) {
      for(int i = 0;i < spaces; i++) 
      { 
        Console.Write(" ");
      }
    }
    public static void writeasterisk(int asteriks)
    {
      for (int i = 0; i < asteriks; i++)
      {
        Console.Write("*");
      }
    }
    public static void mountXmas(ConsoleColor color) {
      Console.ForegroundColor = color;
      mountTree(12, 13);
      mountLog(11, 2, 3);
      mountPot(9, 16);
      sendMerryXmas();
      Thread.Sleep(2000);
    }
    static void Main(string[] args)
    {
      while (true) {
        mountXmas(ConsoleColor.Red);
        Console.Clear();
        mountXmas(ConsoleColor.Blue);
        Console.Clear();
        mountXmas(ConsoleColor.Green);
        Console.Clear();
      }
      
      Console.ReadKey();  
    }
  }
}
