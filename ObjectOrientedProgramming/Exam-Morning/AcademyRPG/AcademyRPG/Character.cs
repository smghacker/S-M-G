﻿using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public abstract class Character : MovingObject, IControllable
    {
        public string Name { get; private set; }

        public Character(string name, Point position, int owner)
            : base(position, owner)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Name;
        }
    }
}
