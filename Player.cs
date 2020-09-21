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
        private Item[] _inventory;

        public Player()
        {
            _name = "none";
            _role = "none";
            _weapon = "none";
            _goldHeld = 0;
            _inventory = new Item[5];
        }

        public Player(string name, string role, string weapon)
        {
            _name = name;
            _role = role;
            _weapon = weapon;
            _goldHeld = 0;
            _inventory = new Item[5];
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

        public int AddGoldToStorage(int addedGold)
        {
            _goldHeld += addedGold;
            return _goldHeld;
        }

        public void PrintStats()
        {
            Console.WriteLine("Player Stats:");
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Role: " + _role);
            Console.WriteLine("Weapon: " + _weapon);
            Console.WriteLine("Gold: " + _goldHeld);
        }

    }
}
