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
            string role = "none";
            string weapon = "none";
            string attackverb = "none";


            //Asks player name.
            Console.WriteLine("Greetings champion, what is yout name? ");
            string name = Console.ReadLine();
            
            //Asks players role.
            Console.WriteLine("Ah, welcome " + name + " to the hall of champions! Please select a role.");
            Console.WriteLine("Press 1 for Knight role.");
            Console.WriteLine("Press 2 for Archer role.");


            //Adjusts stats and a assigns a role depending on what input the player chooses.
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                health = health + 50;
                role = "Knight";
                weapon = "sword";
                attackverb = "slash";

            }
            else if (input == '2')
            {
                health = health - 40;
                role = "Archer";
                weapon = "bow";
                attackverb = "shoot";
            }
            else if (input == '9')
            {
                health = health + 300;
                role = "HERO";
                weapon = "FISTS";
                attackverb = "OBLITERATE";
            }

            //Clears above text.
            Console.Clear();

            //Shows Players beginning stats.
            Console.WriteLine("PLayer Stats:");
            Console.WriteLine("Player name: " + name);
            Console.WriteLine("PLayer level: " + level);
            Console.WriteLine("PLayer role: " + role);
            Console.WriteLine("Player weapon: " + weapon);
            Console.WriteLine("PLayer health:" + health);

            Console.WriteLine("\nPress Enter to begin journey.");
            Console.ReadLine();


            //Beginning of game.
            //Player makes they're way through first area.
            Console.WriteLine("\nYou awake in a meadow, you are surrounded by trees with a single path ahead.");
            Console.WriteLine("\nPress Enter to walk down path.");
            Console.ReadLine();

            Console.WriteLine("You begin to walk down the path for a while then enter a grassy hill plain.");
            Console.WriteLine("\nPress Enter to continue down path.");
            Console.ReadLine();

            Console.WriteLine("\n You walk into the plain and see the ocassional Small Slime popping up and wandering near the path.");
            Console.WriteLine("After walking down the path for a bit longer you see what looks to be a village with a tall stone wall");
            Console.WriteLine("surrounding it in the distance");
            Console.WriteLine("\nPress Enter to continue down path.");
            Console.ReadLine();

            //Player enters Kataberry Village area.
            Console.WriteLine("You begin to approach the village and see the the outline of");
            Console.WriteLine("small buildings within the walls and see the outline of a gate.");
            Console.WriteLine("\nPress Enter to continue down path.");
            Console.ReadLine();

            Console.WriteLine("You get closer to the gate and see a slumbering guard wearing studded leather armor");
            Console.WriteLine("with a Small Slime trying to eat his foot.");
            Console.WriteLine("\nPress Enter to approach gate.");
            Console.ReadLine();

            Console.WriteLine("\nAs you approach the gate, you stop in your tracks as the guard wakes from his slumber ");
            Console.WriteLine("and jumps to his feet prepared for what you might do. He notices the Small Slime and shakes it off.");
            Console.WriteLine("\nPress Enter to talk with the guard,");
            Console.ReadLine();

            Console.WriteLine("'What is your name and business in Kataberry?', the guard asks sternly.");
            Console.WriteLine("\nPress 1 to tell the guard 'My name is " + name + " and I have no business here, Im just passing through'");
            Console.WriteLine("Press 2 to tell the guard 'That is none of your business.'");
            //Player chooses to weither or not to identify themselves to guard.
            char guardQuestion1 = Console.ReadKey().KeyChar;
            if (guardQuestion1 == '1')
            {
                //Player identifies themself to guard. Guard gives player quest.
                Console.WriteLine("\n\n" + name + " huh? I would let you in but with the increase of Small Slimes in the ");
                Console.WriteLine("area we arn't allowed to open the gate unless you have a permit. Well, you look like a capable person");
                Console.WriteLine("carrying that " + weapon + " around. If you do me the favor of taking out some of the"); 
                Console.WriteLine(" Small Slimes around the village walls I will allow you entery. What do you say?");
                Console.WriteLine("\nPress 1 to accpet");
                Console.WriteLine("Press 2 to decline.");
                char guardQuest1 = Console.ReadKey().KeyChar;
                if (guardQuest1 == '1')
                {
                    //Player accepts guard's request and kills slimes.
                    Console.WriteLine("\nThe guard says, 'Ok, come back when you have killed most of the Small Slimes Around the village walls.'");
                    Console.WriteLine(", then goes back to the wall and begins to nap again.");
                    Console.WriteLine("\nPress Enter to begin hunting Small Slimes.");
                    Console.ReadLine();

                    Console.WriteLine("You take your " + weapon + " and begin to slay Small Slimes around the wall, they occasionaly ");
                    Console.WriteLine("drop a piece of gold or small item a villager might have dropped outside the walls. You go to strike on of the");
                    Console.WriteLine("Small Slimes but you graze it and begins to run away in terror.");
                    Console.WriteLine("\nPress Enter to shrug and coninue slaying Small Slimes.");
                    Console.ReadLine();

                    Console.WriteLine("You continue slaying the Small Slimes until most have been slain");
                    Console.WriteLine("You begin to walk back towards the gate when you hear a loud squishing sound in the distance...");
                    Console.WriteLine("\nPress Enter to look for the source of the noise.");
                    Console.ReadLine();

                    //Player encounters Medium Slime and is given an option on how to combat it.
                    Console.WriteLine("You begin to look around and notice the sound is coming from behind a small, nearby hill.");
                    Console.WriteLine("After a second or two of looking at the hill a Medium Slime jumps clear over the hill and begins to jump");
                    Console.WriteLine("angrily towards you.");
                    Console.WriteLine("\nPress 1 to fight Medium Slime.");
                    Console.WriteLine("Press 2 to run towards the gate.");
                    char mediumslimeCombat1 = Console.ReadKey().KeyChar;
                    if (mediumslimeCombat1 == '1')
                    {
                        //
                        Console.WriteLine("You turn towards the slime with your " + weapon + " drawn and ready to fight. As the Medium Slime rushes you, you");
                        Console.WriteLine(attackverb + "it's body and a small chunk of slime falls off.");
                    }
                    else if (mediumslimeCombat1 == '2')
                    {
                        //Player is killed by Medium Slime.
                        Console.WriteLine("\nAs you begin to flee you trip on a small rock and trip. As you get up the Medium Slime jumps onto you");
                        Console.WriteLine("and envelops you in slime. You suffocate and die.");

                        Console.Clear();

                        Console.WriteLine("YOU DIED!");
                        Console.WriteLine("Press Enter to restart.");
                        Console.ReadLine();
                    }

                }
                
            }
            else if (guardQuestion1 == '2')
            {
                //This happens if player inputs 2.
                Console.WriteLine("\n\n'Then begone with you then.', The guard says in an agitated voice.");
                Console.WriteLine("Press enter to walk away.");
                Console.ReadLine();
            }
            


            

           
                
        }

    }
}
