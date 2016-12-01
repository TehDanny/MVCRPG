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
    }
}