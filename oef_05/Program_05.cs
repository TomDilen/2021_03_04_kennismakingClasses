using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_05
{
    class Program_05
    {
        static void Main(string[] args)
        {
            FootballPlayer player1 = new FootballPlayer();
            player1.FootballPlayerConstructor("Joske", 20.0f, 18, FieldPosition.Back);

            FootballPlayer player2 = new FootballPlayer();
            player2.FootballPlayerConstructor("Sofie", 20.0f, 18, FieldPosition.Back);

            FootballPlayer player3 = new FootballPlayer();
            player3.FootballPlayerConstructor("Jefke", 20.0f, 18, FieldPosition.Back);

            FootballPlayer player4 = new FootballPlayer();
            player4.FootballPlayerConstructor("Tomke", 20.0f, 18, FieldPosition.Back);

            FootballPlayer player5 = new FootballPlayer();
            player5.FootballPlayerConstructor("ikbenneevveeeeeeeeeeltelangeNaamvoorneSpeler", 20.0f, 18, FieldPosition.Back);


            Console.WriteLine(player1.TakeTheBallInTheHand());

            Console.WriteLine(player2.Run());

            Console.WriteLine(player5.ShootOnGoal());


            //-------------------------------------------------------------------
            Console.ReadKey();

        }
    }
}
