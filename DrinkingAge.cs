using System;

class DrinkingAge
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    int inputAge = int.Parse(Console.ReadLine());
    if (inputAge >= 21)
    {
        Console.WriteLine("You are old enough to drink!");
    } else
    {
        Console.WriteLine("You are not old enough to drink yet.");
    }
  }
}