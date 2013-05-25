using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public interface IResource : IWorldObject
    {
        int Quantity
        {
            get;
        }

        ResourceType Type
        {
            get;
        }
    }
}
