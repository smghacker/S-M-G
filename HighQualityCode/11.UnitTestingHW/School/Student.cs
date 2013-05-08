using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNS
{
    /*
     *Write three classes: Student, Course and School. Students should have name and unique number (inside the entire School).
     *Name can not be empty and the unique number is between 10000 and 99999. Each course contains a set of students.
     *Students in a course should be less than 30 and can join and leave courses.
     */
    public class Student
    {
        private string name = String.Empty;

        private int uniqueNumber = 0;
        
        public string Name
        {
            get { return this.name; }
            set {
                if (value != null && value != String.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The student name is missing or it is empty", "name");
                }
            }
        }

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("uniqueNumber", "Unique number must be in the range[10 000...100 000]");
                }
            }
        }

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public void JoinCourse(Course course)
        {
            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            course.RemoveStudent(this);
        }
    }
}
