using System;
using System.Linq;

namespace AcademyRolePlayGame
{
    public interface IGatherer : IControllable
    {
        bool TryGather(IResource resource);
    }
}
