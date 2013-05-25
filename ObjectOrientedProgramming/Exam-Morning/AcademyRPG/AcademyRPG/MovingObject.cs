using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public abstract class MovingObject : WorldObject
    {
        public MovingObject(Point position, int owner)
            : base(position, owner)
        {
        }

        public void GoTo(Point destination)
        {
            this.Position = destination;
        }
    }
}
