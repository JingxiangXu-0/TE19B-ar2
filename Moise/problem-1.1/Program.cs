using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightGame
{
  class Program
  {

    static void test(int KongFuHp, int AlCoholicHp)
    {

      Console.WriteLine("KongFu" + 500 + " hp" + "ALCoholic" + 500 + " hp");
      Console.WriteLine();

      int GetKongfuDamage(Random random)
      {
        int attackdamage;
        attackdamage = random.Next(1, 101);
        return attackdamage;
      }
      int GetAlCoholicDamage(Random random)
      {
        int attackdamage;
        attackdamage = random.Next(1, 101);
        return attackdamage;
      }
    }
    static void Main(string[] args)
    {
      Program test = new Program();

      int attackdamage = 0;

      Random random;


      int KongFuHp = 500;
      int AlCoholicHp = 500;

      if (AlCoholicHp > 0)
      {
        attackdamage = test.GetAlCoholic(random);
        KongFuHp -= attackdamage;
      }

      while (AlCoholicHp > 0 && KongFuHp > 0)
      {
        if (AlCoholicHp <= 0)
        {
          Console.WriteLine("Kong Fu IS THE WINNER");
        }

        if (KongFuHp <= 0)
        {
          Console.WriteLine("Al Coholic IS THE WINNER");
        }

      }
    }
  }

}




