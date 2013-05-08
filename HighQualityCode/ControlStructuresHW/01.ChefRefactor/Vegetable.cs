using System;

namespace _01.Chef_refactor
{
    public abstract class Vegetable
    {
        public virtual bool IsRotten { get; set; }
        public virtual bool HasBeenPeeled { get; set; }
    }
}
