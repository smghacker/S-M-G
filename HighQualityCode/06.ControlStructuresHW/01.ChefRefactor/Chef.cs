using System;
using System.Collections.Generic;

namespace _01.Chef_refactor
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.HasBeenPeeled = true;
        }

        private Bowl GetBowl()
        {
            //... 
            return new Bowl(new List<Vegetable>());
        }

        private Potato GetPotato()
        {
            //...
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            //...
            return new Carrot();
        }

        private void Cut(Vegetable potato)
        {
            //...
        }

        static void Main(string[] args)
        {
        }
    }
}
