﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding
{
    public class Rogue : WarriorHero
    {
        private const int DefaultPower = 80;

        public Rogue(string name)
            : base(name, DefaultPower)
        {
        }
    }
}
