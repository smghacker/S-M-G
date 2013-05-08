using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hauptklasse_refacotr
{
    class Civilisation
    {
        enum Gender { ultraBro, coolFemale };

        class Human
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void BuildHuman(int age)
        {
            Human person = new Human();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.ultraBro;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.coolFemale;
            }
        }

        public static void Main()
        {
        }
    }
}
