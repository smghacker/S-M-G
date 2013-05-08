using System;
using System.Collections.Generic;
using _01.Chef_refactor;

namespace IfStatements_refactor
{
    public class IfStatements
    {
        static void Main(string[] args)
        {
            Potato potato = new Potato();
            //... 

            if (potato != null)
            {
                if (!potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            //Second sub-task of refactoring the if-statements
            bool shouldVisitCell = false;
            const int MIN_X = 10;
            const int MAX_X = 20;
            const int MIN_Y = 10;
            const int MAX_Y = 50;
            int x = 12;
            int y = 20;

            if ((x >= MIN_X && x <= MAX_X) &&
                (y >= MIN_Y && y <= MAX_Y) &&
                !shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}

