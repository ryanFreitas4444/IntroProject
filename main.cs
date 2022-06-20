using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Hello and welcome to Ryan's Shoe Store!");
    Console.WriteLine("Please choose a type of shoe you would like to browse: A - running, B - cleat, C - hiking, D - winter");
    
    String userPref = Console.ReadLine();

    if(userPref == "A")
    {
      Console.WriteLine("Come over here to view our running shoes!");
      Console.WriteLine("Would you like to try a couple on?");
      
      String userInput = Console.ReadLine();
      
      if(userInput == "Yes")
      {
        Console.WriteLine("Pick some shoes to try on!");
      }
      else if(userInput == "No")
      {
        Console.WriteLine("Okay, could you provide some details of what you are looking for?");
      }
    }
    
    else if(userPref == "B")
    {
      Console.WriteLine("Come over here to view our cleat selection!");
    }
    
    else if(userPref == "C")
    {
      Console.WriteLine("Come over here to view our hiking boots!");
    }
    
    else if(userPref == "D")
    {
      Console.WriteLine("Come over here to view our winter boots!");
    }
    
    else
    {
      Console.WriteLine("Sorry, we do not carry that type of shoe at this store.");
    }
  }
}