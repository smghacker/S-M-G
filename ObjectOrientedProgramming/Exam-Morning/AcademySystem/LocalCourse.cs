using System;
using System.Linq;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }

        public LocalCourse(string name, ITeacher teacher, string lab) : base(name,teacher)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += String.Format("Lab={0}", this.Lab);

            return result;
        }
    }
}