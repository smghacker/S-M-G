using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null || value != String.Empty)
                {
                    this.name = value;
                }
            }
        }

        public List<ICourse> Courses { get; set; }

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Teacher: Name={0}; ", this.name));
            if (this.Courses.Count != 0)
            {
                result.Append(String.Format("Courses=["));
                for (int i = 0; i < this.Courses.Count; i++)
                {
                    if (i == this.Courses.Count - 1)
                    {
                        result.Append(String.Format("{0}", this.Courses[i]));
                    }
                    else
                    {
                        result.Append(String.Format("{0}, ", this.Courses[i]));
                    }
                }
                result.Append("]");
            }
            else
            {
                result.Length--;
                result.Length--;
            }
            return result.ToString();
        }
    }
}