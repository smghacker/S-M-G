using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public interface IWorldObject
    {
        bool IsDestroyed
        {
            get;
        }

        int HitPoints
        {
            get;
            set;
        }

        Point Position
        {
            get;
        }
    }
}
