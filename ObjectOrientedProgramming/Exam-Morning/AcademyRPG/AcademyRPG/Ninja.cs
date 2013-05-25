using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyRolePlayGame
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public int AttackPoints
        {
            get;
            private set;
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int highestHitPoints = 0;
            int positionOfObject = 0;
            bool isNinjaOpponentFound = false;

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 
                    && availableTargets[i].HitPoints > highestHitPoints)
                {
                    isNinjaOpponentFound = true;
                    highestHitPoints = availableTargets[i].HitPoints;
                    positionOfObject = i;
                 }
            }
            if (isNinjaOpponentFound == true)
            {
                return positionOfObject;
            }
            else
            {
                return -1;
            }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ninja(string name, Point position, int owner)
            :base(name,position,owner)
        {
            this.HitPoints = 1;
        }
    }
}
