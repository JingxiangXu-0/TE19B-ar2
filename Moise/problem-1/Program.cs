using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_Game

{
  class Program
  {
    void DisplayChoices(int heroHitPoints, int monsterHitPoints)
    {
      Console.Write(@"
************************************************
Your hero has {0}hp and the Monster has {1}hp
************************************************", heroHitPoints, monsterHitPoints);

      Console.Write(@"
__________________________
Please Choose an action:
(A)ttack
(D)efend
(H)eal
(F)lee
__________________________");
      Console.WriteLine();
    }
    int GetHeroDamage(Random rand)
    {
      int attackdamage;
      attackdamage = rand.Next(350, 450);
      return attackdamage;
    }
    int GetMonsterDamage(Random rand)
    {
      int attackdamage;
      attackdamage = rand.Next(250, 350);
      return attackdamage;
    }
    static void Main(string[] args)
    {
      Program CH = new Program();
      int heroHitPoints, monsterHitPoints, attackdamage, healing, fleechance, hitchance;
      Random rand;
      string battlechoice;
      Console.WriteLine("You are facing a Monster!");


      heroHitPoints = 1500;
      monsterHitPoints = 2000;
      do
      {
        rand = new Random();
        CH.DisplayChoices(heroHitPoints, monsterHitPoints);
        battlechoice = Console.ReadLine();
        switch (battlechoice)
        {
          case "a":
          case "A":
            hitchance = rand.Next(0, 100);
            if (hitchance > 30)
            {
              attackdamage = CH.GetHeroDamage(rand);
              Console.WriteLine("The hero attacks!");
              monsterHitPoints -= attackdamage;
              Console.WriteLine("The monster loses {0}hp", attackdamage);
            }
            else
            {
              Console.WriteLine("You missed!");
            }
            break;
          case "d":
          case "D":
            Console.WriteLine("The Hero Defends");
            break;
          case "h":
          case "H":
            healing = 400;
            heroHitPoints += healing;
            Console.WriteLine("The Hero uses a Potion!");
            Console.WriteLine("The Hero heals himself for {0} Points", healing);
            break;
          case "f":
          case "F":
            fleechance = rand.Next(0, 100);
            if (fleechance > 40)
            {
              Console.WriteLine("The hero fled!");
              Console.ReadLine();
              Environment.Exit(0);
            }
            else
            {
              Console.WriteLine("Fleeing Failed");
              Console.ReadLine();

            }
            break;
          default:
            Console.WriteLine("Sorry that choice was invalid and the monster took a cheap shot!");
            break;
        }

        Console.WriteLine();
        if (monsterHitPoints > 0)
        {
          hitchance = rand.Next(0, 100);
          if (hitchance > 30)
          {
            attackdamage = CH.GetMonsterDamage(rand);
            Console.WriteLine("The Monster Attacks!");
            if (battlechoice == "d" || battlechoice == "D")
            {
              attackdamage /= 2;
            }
            heroHitPoints -= attackdamage;
            Console.WriteLine("The Hero loses {0}hp", attackdamage);
          }
          Console.WriteLine("Press Enter to Continue");
          Console.ReadLine();
          Console.Clear();
        }
      }
      while (heroHitPoints > 0 && monsterHitPoints > 0);

      if (heroHitPoints > 0)
      {
        Console.WriteLine("You are Victorious!");
      }
      else
      {
        Console.WriteLine("You have been defeated :(");
      }
      Console.ReadLine();
    }
  }

}