using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public abstract class StaticObject : WorldObject
    {
        public StaticObject(Point position, int owner = 0)
            : base(position, owner)
        {
        }
    }
}
