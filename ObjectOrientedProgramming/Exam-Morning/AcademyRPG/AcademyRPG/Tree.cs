﻿using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public class Tree : StaticObject, IResource
    {
        protected int Size { get; private set; }

        public ResourceType Type 
        { 
            get 
            { 
                return ResourceType.Lumber; 
            } 
        }

        public int Quantity
        {
            get
            {
                return this.Size;
            }
        }

        public Tree(int size, Point position)
            : base(position)
        {
            this.Size = size;
            this.HitPoints = size;
        }
    }
}
