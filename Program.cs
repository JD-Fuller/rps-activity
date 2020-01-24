using System;

namespace rps_activity
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine($@"Welcome to the Thunderdome!
      
      Are you ready to play?");

      String res = Console.ReadLine().ToLower();
      Console.WriteLine($@"Let the games begin!" + "Make your selection");
      Console.WriteLine("R for Rock - P for Paper - S for Scissor");
      bool validating = true;
      while (validating)
      {
        if (res != "y")
        {
          Console.WriteLine("Well, I guess we'll see you later then.");
          break;
        }
        else
        {
          String selection = Console.ReadLine().ToLower();

          String[] winStatements = { "You win human...for now", "How dare you defy me!", "You win petty carbon based life form!", "This will not stand, I demand a rematch", "You cheated!", "Enough, I'm done losing to you human", "Get out, I'm tired of your petty wins", "This will not be forgotten human - you win now, but watch your back" };


          String[] computerChoices = { "p", "s", "r" };
          Random rand = new Random();
          int index = rand.Next(computerChoices.Length);
          int windex = rand.Next(winStatements.Length);


          if (selection.Equals(computerChoices[index]))
          {
            Console.WriteLine("Tie ball game - try again");
          }
          else if (selection == "r" && computerChoices[index] == "s")
          {
            Console.WriteLine("You win human...for now");
          }
          else if (selection == "p" && computerChoices[index] == "r")
          {
            Console.WriteLine(winStatements[windex]);
          }
          else if (selection == "s" && computerChoices[index] == "p")
          {
            Console.WriteLine(winStatements[windex]);
          }
          else
          {
            Console.WriteLine("you lose");
          }
        }

      }












    }
  }
}
