﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player : IPlayer
    {
        public String Name { get; set; }

        public Player(string name)
        {
            Name = name; 
        }
    }

}
