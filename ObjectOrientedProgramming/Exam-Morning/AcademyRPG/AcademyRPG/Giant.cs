using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyRolePlayGame
{
    public class Giant : Character, IGatherer, IFighter
    {
        private int numberOfIncreasingPower = 1;

        private int attackPoints = 150;

        public Giant(string name, Point position) : base(name, position, 0)
        {
            this.HitPoints = 200;
        }

        public int NumberOfIncreasingPower
        {
            get
            {
                return this.numberOfIncreasingPower;
            }
            private set
            {
                this.numberOfIncreasingPower = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return 80;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (this.NumberOfIncreasingPower == 1)
                {
                    this.AttackPoints += 100;
                    this.NumberOfIncreasingPower = 0;
                }
                return true;
            }

            return false;
        }
    }
}