using DnDCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCore
{
    public class Player : IPlayer
    {
        public string Name { get; set; } = "";
        public int Health { get; set; }
        public int DamageDone { get; set; }
        public int DamageTaken { get; set; }

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
            DamageDone = 0;
            DamageTaken = 0;
        }
    }
}
