using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        //Constructors
        public Course(string name, string teacherName)
        {
            this.Name=name;
            this.TeacherName=teacherName;
        }

        //Methods
        public virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
