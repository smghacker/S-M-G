using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public class Rock : StaticObject, IResource
    {
        public int Quantity
        {
            get
            {
                return this.HitPoints/2;
            }
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }
        public Rock(Point position, int hitp)
            :base(position)
        {
            this.HitPoints = hitp;
        }
    }
}
