using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRPG.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private const int defaultHealth = 100;

        public Character(string name)
        {
            Name = name;
            Health = defaultHealth;
        }

        /*
        public static void Create(string name)
        {
            Character character = new Character(name);
            if (GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();
            GlobalVariables.Characters.Add(character);
        }
        */

        public static List<Character> GetAll()
        {
            return GlobalVariables.Characters;
        }
    }
}