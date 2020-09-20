using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class game
    {
        private Player _player;
        bool _gameOver = false;
        public bool mysteryBerryEffect = false;

        //Will recive input from the player.
        public void GetInput(out char input, string option1, string option2, string query)
        {

            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        public void PressEnterTo(string query)
        {
            Console.WriteLine("Press enter to " + query);
            Console.ReadKey();
        }

        public Player CreateCharacter()
        {
            Console.WriteLine("Greetings champion, what is yout name? ");
            string name = Console.ReadLine();
            string role = "none";
            string weapon = "none";

            Console.WriteLine("Ah, welcome " + name + ", to the hall of champions!");
            char input = ' ';
            GetInput(out input, "Knight", "Archer", "Please select a role");
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

            Player player = new Player(name, role, weapon);
            return player;
        }

        //This puts the player in an endless room.
        void endlessRoom(int stepsTaken)  
        {
            switch (stepsTaken)
            {
                case 0:
                    {
                        Console.WriteLine("You appear in a big open room with a wooden door on the far side of the room.");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("You take a couple steps forward but somthing seemed off...");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("You continue to walk but it seems the door keeps moving away from you...");
                        break;
                    }
            }

            char input = ' ';
            GetInput(out input, "Walk forward", "Walk back", "What direction do you want to go?");
            if (input == '1')
            {
                Console.Clear();
                endlessRoom(stepsTaken + 2);
                Console.WriteLine("Steps taken: " + stepsTaken);
            }
            else if(input == '2')
            {
                Console.Clear();
                endlessRoom(stepsTaken - 2);
                Console.WriteLine("Steps taken: " + stepsTaken);
            }
        }

        public void Start()
        {
            _player = CreateCharacter();
        }

        public void Update()
        {
            AreaOne();
            /*
            AreaTwo();
            AreaThree();
            AreaFour();
            AreaFive();
            AreaSix();
            */
        }

        public void End()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER!");
        }

        public void Run()
        {
            Start();

            while(_gameOver == false)
            {
                Update();
            }

            End();

        }

        //Player makes way through the first area.
        public void AreaOne()
        {
            Console.Clear();
            PressEnterTo("begin journey.");

            _player.AddGoldToStorage(43);
            Console.WriteLine("\nYou awake flat on your back in a meadow. You lean foward and notice a " + _player.GetWeapon() + " and small leather pouch next to you.");
            Console.WriteLine("You stand up and grab the " + _player.GetWeapon() + " and the pouch. You open the pouch and it contained many gold pieces.");
            Console.WriteLine("You look around the meadow and notice a narrow dirt path between some trees.");
            Console.WriteLine("You gain 43 gold pieces.");
            _player.PrintStats();
            PressEnterTo("go down path.");

            //Player is given choise to eat a berry that has unknown effects.
            Console.WriteLine("\nAs you are walking down the path you notice a bush with round, small, orange berries that are about");
            Console.WriteLine("the size of the palm of your hand.");
            char input = ' ';
            GetInput(out input, "Eat Mystery Berry", "Continue walking down path", "What do you want to do?");
            if (input == '1')
            {
                //PLayer tastes berry but not enough to effect them. Player is given option to eat more or leave.
                Console.WriteLine("\nYou pick one berry to taste it. The taste was sweet and you feel no negative effects from the berry.");

                GetInput(out input, "Continue eating berries", "Continue down path", "What do you want to do?");
                if (input == '1')
                {
                    //Player eats many berries. Player is effected by the Mysterious Berry but does not know.
                    Console.WriteLine("\nYou continue to eat the Mystery Berries in handfulls at a time.");
                    PressEnterTo("eat more Mystery Berries.");

                    Console.WriteLine("\nYou eat the berries until you are full.");
                    PressEnterTo("continue journey.");
                    mysteryBerryEffect = true;
                }
                else if (input == '2')
                {
                    //Player does not eat anymore berries and continues down path.
                    Console.WriteLine("\nYou turn away and continue on your journey.");
                    PressEnterTo("continue.");
                }
            }
            else if (input == '2')
            {
                //Player does not eat berries and leaves
                Console.WriteLine("\nYou turn away from the berries and continue down the path.");
                PressEnterTo("continue down path.");
            }
            else
            {
                Console.WriteLine("\nThat is not a valid input.");
            }

            //Player continues down path then runs into riddle gate.
            Console.Clear();
            Console.WriteLine("\nYou begin to walk down the path for a while then stumble upon a gate with a lion insignia in the middle.");
            PressEnterTo("inspect gate.");


            //Player is given a option to decline or accept riddle.
            Console.Clear();
            Console.WriteLine("\nAs you are inspecting the gate the lion's mouth opens and says:");
            Console.WriteLine("'Answer my riddle and you may pass through my gate.'");
            GetInput(out input, "Accept riddle", "Delcine riddle", "What do you want to do?");
            if (input == '1')
            {
                for (int i = 0; i < 5; i++)
                {
                    //Player accepts riddle and is given 5 tries to answer correctly.
                    string guess = " ";
                    Console.Clear();
                    Console.WriteLine("\nAfter accepting, a stone podium appears out of the ground with the following riddle:");
                    Console.WriteLine("\n'I have a mouth but do not speak, I have a bed but do not sleep, I run every were but go know were, what am I...'");
                    Console.WriteLine("You have " + (5 - i) + " tries remaining");
                    guess = Console.ReadLine();
                    if (guess == "river")
                    {
                        //This displays if the player enters the correct answer to the riddle.
                        Console.WriteLine("You guess correctly and the gate opens allowing you to pass.");
                        PressEnterTo("continue down path.");
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        //This displays when player does not enter correct answer to riddle.
                        Console.WriteLine("That is incorrect, press Enter to try again.");
                        Console.ReadLine();
                    }
                }
            }
            else if (input == '2')
            {
                //Player declines lions riddle and is killed by the lion.
                Console.WriteLine("\nYou decline the lion's offer.");
                Console.WriteLine("\n'Dont deny me entertainment.', says the lion.");
                Console.WriteLine("You go to look at the lion and then everything goes black......");
                PressEnterTo("continue.");

                _gameOver = true;
            }

            Console.WriteLine("You walk pass the gates and can now continue down the path.");
            PressEnterTo("continue down path.");

            Console.WriteLine("\n After walking for a while, you emerge into a big open clearing with a small village with a wooden wall surrounding it.");
            Console.WriteLine("You also notice many Small Slimes in the area.");
            PressEnterTo("continue.");

            Console.Clear();

            Console.WriteLine("You begin to approach the village and see the the outline of");
            Console.WriteLine("small buildings within the walls and see the outline of a gate.");
            PressEnterTo("continue down path.");

            Console.WriteLine("\nYou get closer to the gate and see a slumbering guard wearing studded leather armor");
            Console.WriteLine("with a Small Slime trying to eat his foot.");
            PressEnterTo("approach gate.");

            Console.WriteLine("\nAs you approach the gate, you stop in your tracks as the guard wakes from his slumber ");
            Console.WriteLine("and jumps to his feet and grabs the hilt of his sword, prepared for what you might do.");
            Console.WriteLine("He notices the Small Slime and shakes it off.");
            PressEnterTo("talk with the guard");

            Console.WriteLine("\n'What is your name and business in Kataberry?', the guard asks sternly.");
            //Player chooses to weither or not to identify themselves to guard.
            GetInput(out input, "Tell guard your name and that you have no business", "Tell guard that isnt his business", "Wha do you want to do?");
            if (input == '1')
            {
                //Player identifies themself to guard. Guard gives player quest.
                Console.WriteLine("\n\n" + _player.GetName() + " huh? I would let you in but your face isnt one i've seen before, and with the ");
                Console.WriteLine("recent bandit clan that moved into the hills we don't take kindly to strangers. Hmmmm... you look like");
                Console.WriteLine("a good enough person but you carrying that " + _player.GetWeapon() + " around... you look to suspicious for me to let you in.");
                Console.WriteLine("I'll make you a deal, a freelance swords-man was supposed to come and kill these Small Slimes but hasn't shown up.");
                Console.WriteLine("up yet. If you slay the slimes and i'll let you in.");
                PressEnterTo("accept");

                Console.WriteLine("\nThe guard says, 'Ok, come back when you have killed most of the Small Slimes Around the village walls.'");
                Console.WriteLine("then procceds to walk back the wall to nap again.");
                PressEnterTo("begin hunting Small Slimes.");


                Console.WriteLine("You take your " + _player.GetWeapon() + " and begin to slay Small Slimes around the wall, they occasionaly ");
                Console.WriteLine("drop a piece of gold or small item a villager might have dropped outside the walls. You attack one of the");
                Console.WriteLine("Small Slimes but you graze it and begins to run away in terror.");
                PressEnterTo("shrug and coninue slaying Small Slimes.");

                Console.WriteLine("You continue slaying the Small Slimes until most have been slain");
                Console.WriteLine("You begin to walk back towards the gate when you hear a loud squishing sound in the distance...");
                PressEnterTo("look for the source of the noise.");

                //Player encounters Medium Slime.
                Console.WriteLine("You begin to look around and notice the sound is coming from the forest.");
                Console.WriteLine("After a second or two of looking at the trees a Medium Slime, with the same small slime you grazed, begins to jump");
                Console.WriteLine("angrily towards you. The Small Slime jumps off the Medium Slime as it rushes towards you.");
                Console.WriteLine();



            }
            //Player inputs 2 to deny to validate themselves.
            //Player is teleported to an endless dungeon.
            else if (input == '2')
            {

                Console.WriteLine("\n\n'Then begone with you then.', The guard says in an agitated voice.");
                PressEnterTo("walk away");
                Console.WriteLine("\nYou feel weird as you go to walk away. The world begins to spin.....");
                PressEnterTo("continue.....");

                Console.Clear();

                endlessRoom(0);


            }
        }


        public void AreaTwo()
        {
            Console.WriteLine("You have entered KataBerry Village");
            PressEnterTo("continue");

            Console.WriteLine("You enter the village market square");
        }
    }
}