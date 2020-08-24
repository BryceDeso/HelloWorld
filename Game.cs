using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {

            bool gameOver = false;
            while (gameOver == false)
            {
                //Base player stats for any character.

                //PLayers base level
                float level = 1;
                //Determinds players role
                string role = "none";
                //Determinds players weapon
                string weapon = "none";
                //Keeps track of the amount of gold player is holding.
                float goldHeld = 0f;

                //Beginning of game.

                //Asks player name.
                Console.WriteLine("Greetings champion, what is yout name? ");
                string name = Console.ReadLine();

                //Asks players role.
                Console.WriteLine("Ah, welcome " + name + " to the Hall of Champions! Please select a role.");
                Console.WriteLine("Press 1 for Knight role.");
                Console.WriteLine("Press 2 for Archer role.");

                //Adjusts stats and a assigns a role depending on what input the player chooses.
                char input = ' ';
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        role = "Knight";
                        weapon = "sword";
                    }
                    else if (input == '2')
                    {
                        role = "Archer";
                        weapon = "bow";
                    }
                    else
                    {
                        Console.WriteLine("Input not vaild.");
                    }
                }

                //Clears above text.
                Console.Clear();

                //Shows Players beginning stats.
                Console.WriteLine("PLayer Stats:");
                Console.WriteLine("Player name: " + name);
                Console.WriteLine("PLayer level: " + level);
                Console.WriteLine("PLayer role: " + role);
                Console.WriteLine("Player weapon: " + weapon);
                Console.WriteLine("\nPress Enter to begin journey.");
                Console.ReadKey();


                //Player makes they're way through first area.
                goldHeld = goldHeld + 43;
                Console.WriteLine("\nYou awake flat on your back in a meadow. You lean foward and notice a " + weapon + " and small leather pouch next to you.");
                Console.WriteLine("You stand up and grab the " + weapon + " and the pouch. You open the pouch and it contained many gold pieces.");
                Console.WriteLine("You look around the meadow and notice a narrow dirt path between some trees.");
                Console.WriteLine("You gain 43 gold pieces.");
                Console.WriteLine("\nPress Enter to walk down path.");
                Console.ReadKey();

                //Player is given choise to eat a berry that has unknown effects.
                Console.WriteLine("\nAs you are walking down the path you notice a bush with round, small, orange berries that are about");
                Console.WriteLine("the size of the palm of your hand.");
                Console.WriteLine("Press 1 to eat Mystery Berries");
                Console.WriteLine("Press 2 to continue walking down path.");
                char mysteryBerryOptionOne = ' ';
                while (mysteryBerryOptionOne != '1' || mysteryBerryOptionOne != '2')
                {
                    mysteryBerryOptionOne = Console.ReadKey().KeyChar;
                    if (mysteryBerryOptionOne == '1')
                    {
                        //PLayer tastes berry but not enough to effect them. Player is given option to eat more or leave.
                        Console.WriteLine("\nYou pick one berry to taste it. The taste was sweet and you feel no negative effects from the berry.");
                        Console.WriteLine("Continue eating Mystery Berries?");
                        Console.WriteLine("Press 1 to continue eating.");
                        Console.WriteLine("Press 2 to continue down path.");
                        char mysteryBerryOptionTwo = ' ';
                        mysteryBerryOptionTwo = Console.ReadKey().KeyChar;
                        if (mysteryBerryOptionTwo == '1')
                        {
                            //Player eats many berries. Player is effected by the Mysterious Berry but does not know.
                            bool mysteryBerryEffect = true;
                            Console.WriteLine("\nYou continue to eat the Mystery Berries in handfulls at a time.");
                            Console.WriteLine("Press Enter to eat more Mystery Berries.");
                            Console.ReadKey();

                            Console.WriteLine("\nYou eat the berries until you are full.");
                            Console.WriteLine("Press Enter to continue journey.");
                            Console.ReadKey();
                            break;
                        }
                        else if (mysteryBerryOptionTwo == '2')
                        {
                            //Player does not eat anymore berries and continues down path.
                            Console.WriteLine("\nYou turn away and continue on your journey.");
                            Console.WriteLine("Press Enter to continue.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nThat is not a valid input.");
                        }
                    }
                    else if (mysteryBerryOptionOne == '2')
                    {
                        //Player does not eat berries and leaves
                        Console.WriteLine("\nYou turn away from the berries and continue down the path.");
                        Console.WriteLine("Press Enter to continue down path.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThat is not a valid input.");
                    }
                }


                //Player continues down path then runs into riddle gate.
                Console.Clear();
                Console.WriteLine("\nYou begin to walk down the path for a while then stumble upon a gate with a lion insignia in the middle.");
                Console.WriteLine("\nPress Enter to inspect gate.");
                Console.ReadKey();

                //Player is given a option to decline or accept riddle.
                Console.WriteLine("\nAs you are inspecting the gate the lion's mouth opens and says:");
                Console.WriteLine("'Answer my riddle and you may pass through my gate.'");
                Console.WriteLine("Press 1 to accept riddle.");
                Console.WriteLine("Press 2 to decline riddle.");
                char gateRiddle = ' ';
                gateRiddle = Console.ReadKey().KeyChar;
                if (gateRiddle == '1')
                {
                    for (int i = 0; i < 5; i++)
                    {
                        //Player accepts riddle and is given 5 tries to answer correctly.
                        string guess = " ";
                        Console.Clear();
                        Console.WriteLine("\nAfter accepting, a stone podium appears out of the ground with the following riddle:");
                        Console.WriteLine("\nI have a mouth but do not speak, I have a bed but do not sleep, I run every were but go know were, what am I");
                        Console.WriteLine("You have " + (5 - i) + " tries remaining.");
                        guess = Console.ReadLine();
                        if (guess == "river")
                        {
                            //This displays if the player enters the correct answer to the riddle.
                            Console.WriteLine("You guess correctly and the gate opens allowing you to pass.");
                            Console.WriteLine("Press Enter to continue down path.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            //This displays when player does not enter correct answer to riddle.
                            Console.WriteLine("That is incorrect, press Enter to try again.");
                            Console.ReadLine();
                        }
                    }
                }
                else if (gateRiddle == '2')
                {
                    //Player declines lions riddle and is killed by the lion.
                    Console.WriteLine("\nYou decline the lion's offer.");
                    Console.WriteLine("As you walk away the lion reaches a paw out and slices your head off.");
                    Console.WriteLine("'Dont Deny me my entertainment', says the lion.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("YOU DIED!");
                    Console.WriteLine("\nPress Enter to restart.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }

                Console.WriteLine("You walk pass the gates and can now continue down the path.");
                Console.WriteLine("Press Enter to continue down path.");
                Console.ReadKey();
                /*
                Console.WriteLine("\n After walking for a bit , you walk into the plain and see the ocassional Small Slime popping up and wandering near the path.");
                Console.WriteLine("After walking down the path for a bit longer you see what looks to be a village with a tall stone wall");
                Console.WriteLine("surrounding it in the distance");
                Console.WriteLine("\nPress Enter to continue down path.");
                Console.ReadKey();
                */

                //Player enters Kataberry Village area.
                Console.Clear();

                Console.WriteLine("You begin to approach the village and see the the outline of");
                Console.WriteLine("small buildings within the walls and see the outline of a gate.");
                Console.WriteLine("\nPress Enter to continue down path.");
                Console.ReadKey();

                Console.WriteLine("\nYou get closer to the gate and see a slumbering guard wearing studded leather armor");
                Console.WriteLine("with a Small Slime trying to eat his foot.");
                Console.WriteLine("\nPress Enter to approach gate.");
                Console.ReadKey();

                Console.WriteLine("\nAs you approach the gate, you stop in your tracks as the guard wakes from his slumber ");
                Console.WriteLine("and jumps to his feet prepared for what you might do. He notices the Small Slime and shakes it off.");
                Console.WriteLine("\nPress Enter to talk with the guard");
                Console.ReadKey();

                char guardQuestionOne = ' ';
                while (guardQuestionOne != '1' || guardQuestionOne != '2')
                {
                    Console.WriteLine("\n'What is your name and business in Kataberry?', the guard asks sternly.");
                    Console.WriteLine("\nPress 1 to tell the guard 'My name is " + name + " and I have no business here, Im just passing through'");
                    Console.WriteLine("Press 2 to tell the guard 'That is none of your business.'");
                    //Player chooses to weither or not to identify themselves to guard.
                    guardQuestionOne = Console.ReadKey().KeyChar;
                    if (guardQuestionOne == '1')
                    {
                        //Player identifies themself to guard. Guard gives player quest.
                        Console.WriteLine("\n\n" + name + " huh? I would let you in but with the increase of Small Slimes in the ");
                        Console.WriteLine("area we arn't allowed to open the gate unless you have a permit. Well, you look like a capable person");
                        Console.WriteLine("carrying that " + weapon + " around. If you do me the favor of taking out some of the");
                        Console.WriteLine("Small Slimes around the village walls I will allow you entery.");
                        Console.WriteLine("\nPress Enter to accept");

                        //Player accepts guard's request and kills slimes.
                        Console.WriteLine("\nThe guard says, 'Ok, come back when you have killed most of the Small Slimes Around the village walls.'");
                        Console.WriteLine("then procceds to walk back the wall to nap again.");
                        Console.WriteLine("\nPress Enter to begin hunting Small Slimes.");
                        Console.ReadLine();

                        Console.WriteLine("You take your " + weapon + " and begin to slay Small Slimes around the wall, they occasionaly ");
                        Console.WriteLine("drop a piece of gold or small item a villager might have dropped outside the walls. You attack one of the");
                        Console.WriteLine("Small Slimes but you graze it and begins to run away in terror.");
                        Console.WriteLine("\nPress Enter to shrug and coninue slaying Small Slimes.");
                        Console.ReadLine();

                        Console.WriteLine("You continue slaying the Small Slimes until most have been slain");
                        Console.WriteLine("You begin to walk back towards the gate when you hear a loud squishing sound in the distance...");
                        Console.WriteLine("\nPress Enter to look for the source of the noise.");
                        Console.ReadLine();

                        //Player encounters Medium Slime.
                        Console.WriteLine("You begin to look around and notice the sound is coming from behind a small, nearby hill.");
                        Console.WriteLine("After a second or two of looking at the hill a Medium Slime with the same small slime you grazed,jumps clear over the hill and begins to jump");
                        Console.WriteLine("over the hill and begins to jump over the hill and begins to jump and begins to jump angrily towards you.");
                        Console.WriteLine("The Small Slime jumps off the Medium Slime as it rushes towards you.");
                        Console.WriteLine();




                    }
                    else if (guardQuestionOne == '2')
                    {
                        //Player inputs 2 to deny to validate themselves.
                        Console.WriteLine("\n\n'Then begone with you then.', The guard says in an agitated voice.");
                        Console.WriteLine("Press enter to walk away.");
                        Console.ReadKey();


                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input.");
                        Console.WriteLine("Press Enter to ");
                    }
                }


                Console.Clear();

                //Player enters Kataberry Village.
                Console.WriteLine("'You enter Kataberry Village'");
                Console.WriteLine("You enter kataberry and the first thing you see is the Market Square humming with life as");
                Console.WriteLine("people trying to buy and sell a variety of wares.");
            }
        }


    }
}
