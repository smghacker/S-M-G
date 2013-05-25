using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public interface IControllable : IWorldObject
    {
        string Name
        {
            get;
        }
    }
}
