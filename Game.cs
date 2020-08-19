using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Player beginning Stats.
            float health = 100.0f;
            int level = 1;
            float damage = 3;
            
            //Asks player name.
            Console.WriteLine("Greetings champion, what is yout name? ");
            string name = Console.ReadLine();
            //Asks players role.
            Console.WriteLine("Ah, welcome " + name + " to the hall of champions! What is your role? ");
            string role = Console.ReadLine();
            //Asks player what his weapon is.
            Console.WriteLine("So, your a " + role + " huh? Then pick your weapon of choise?");
            string weapon = Console.ReadLine();
            
            //Shows Players beginning stats.
            Console.WriteLine("PLayer Stats:");
            Console.WriteLine("Player name: " + name);
            Console.WriteLine("PLayer level: " + level);
            Console.WriteLine("PLayer damage: " + damage);
            Console.WriteLine("PLayer role: " + role);
            Console.WriteLine("PLayer weapon: " + weapon);
            Console.WriteLine("PLayer health:" + health);

            bool ready = true;

            //Beginning of game.
            Console.Write("You awake in a meadow, you see a gate ahead with a guard. You con see multiple small slimes wandering " +
                "aimlessly in the  meadow. What do you do? (Type 1 to talk to guard, Type 2 to attack Small Slime) ");

            Console.ReadLine();
            {

            }

        }

    }
}
