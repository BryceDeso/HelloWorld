using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    class Player
    {
        private string _name;
        private string _role;
        private string _weapon;
        private int _goldHeld;

        public Player()
        {
            _name = "none";
            _role = "none";
            _weapon = "none";
            _goldHeld = 0;
        }

        public Player(string name, string role, string weapon)
        {
            _name = name;
            _role = role;
            _weapon = weapon;
            _goldHeld = 0;            
        }

        public string GetName()
        {
            return _name;
        }

        public string GetRole()
        {
            return _role;
        }

        public string GetWeapon()
        {
            return _weapon;
        }

        public int GetHeldGold()
        {
            return _goldHeld;
        }

        public void PrintStats()
        {
            Console.WriteLine("PLayer Stats:");
            Console.WriteLine("Player name: " + _name);
            Console.WriteLine("PLayer role: " + _role);
            Console.WriteLine("Player weapon: " + _weapon);
        }

    }
}
