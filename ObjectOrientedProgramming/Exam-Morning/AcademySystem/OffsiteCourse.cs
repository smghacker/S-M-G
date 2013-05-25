using System;
using System.Linq;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, ITeacher teacher, string town) : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += String.Format("Town={0}", this.Town);

            return result;
        }
    }
}