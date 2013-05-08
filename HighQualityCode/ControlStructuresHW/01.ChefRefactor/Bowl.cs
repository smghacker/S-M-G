using System;
using System.Collections.Generic;

namespace _01.Chef_refactor
{
    public class Bowl
    {
        List<Vegetable> vegetables = new List<Vegetable>();

        public Bowl(List<Vegetable> vegetables)
        {
            this.Vegetables = vegetables;
        }

        public List<Vegetable> Vegetables
        {
            get { return vegetables; }
            set { vegetables = value; }
        }

        public void Add(Vegetable vegetable)
        {
            this.Vegetables.Add(vegetable);
        }

        public void Remove(Vegetable vegetable)
        {
            this.Vegetables.Remove(vegetable);
        }
    }
}
