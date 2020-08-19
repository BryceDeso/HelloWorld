using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Base player stats for any character.
            float health = 100.0f;
            float level = 1;
            float damage = 10.0f;
            string role = "none";
            string weapon = "none";


            //Asks player name.
            Console.WriteLine("Greetings champion, what is yout name? ");
            string name = Console.ReadLine();
            
            //Asks players role.
            Console.WriteLine("Ah, welcome " + name + " to the hall of champions! Please select a role.");
            Console.WriteLine("Press 1 for Knight role.");
            Console.WriteLine("Press 2 for Mage role.");


            //Adjusts stats and a assigns a role depending on what input the player chooses.
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = health + 50;
                role = "Knight";
                weapon = "sword";

            }
            else if (input == '2')
            {
                damage = damage + 30;
                health = health - 40;
                role = "Mage";
                weapon = "Staff";
            }

            //Clears above text.

            Console.Clear();

            //Shows Players beginning stats.
            Console.WriteLine("PLayer Stats:");
            Console.WriteLine("Player name: " + name);
            Console.WriteLine("PLayer level: " + level);
            Console.WriteLine("PLayer damage: " + damage);
            Console.WriteLine("PLayer role: " + role);
            Console.WriteLine("Player weapon: " + weapon);
            Console.WriteLine("PLayer health:" + health);
            

            //Beginning of game.
            Console.WriteLine("\nYou awake in a meadow, you see a gate ahead with a guard. You can see multiple Small Slimes wandering " +
            "aimlessly in the  meadow.");
            Console.WriteLine("Press any key to talk to guard.");
            Console.WriteLine("Press 2 to inspect Small Slimes.");

            char input1 = Console.ReadKey().KeyChar;
            if (input1 == '1')
            {
                //This is the dialouge if the player picks input 1.
                Console.WriteLine("\nAs you approach the guard he asks: ");
                Console.WriteLine("What is your purpose?!");
                Console.WriteLine("Press any key to ask for entry to the gate.");
                Console.ReadLine();
                Console.WriteLine("\nHmm... I'll allow you entry if you take out those pestering Small Slimes in this meadow.");

            }
            else if (input1 == '2')
            {

                Console.WriteLine("\nThe Small Slimes are a blue-ish green color, there are only about" +
                    "five Small Slimes in the meadow and they look weak...  very weak...");
                Console.WriteLine("Press any key to crush Small Slimes");
                char question2 = Console.ReadKey().KeyChar;
                if (question2 == '1')
                {
                    Console.WriteLine("\nYou walk away from Small Slimes.");
                }
                else if (question2 == '2')
                {
                    Console.Write("\nYou ruthlessly attack the poor helpless Small Slimes, but during your attack a " +
                        "Medium Slime Appears.");
                    Console.WriteLine("\nPress 1 to run away.");
                    Console.WriteLine("Press 2 to attack Medium Slime.");
                    char combat = Console.ReadKey().KeyChar;
                    if (combat == '1')
                    {
                        health = health - health;
                        Console.WriteLine("\nAs you go to flee, you trip on a small rock and the Medium " +
                            "Slime incases you in slime. You suffocate.");
                    }
                    else if (combat == '2')
                    {
                        Console.WriteLine("\nYou fight the Medium Slime for a bit before you finally kill it.");
                    }
                }
            }

            

            

        }

    }
}
