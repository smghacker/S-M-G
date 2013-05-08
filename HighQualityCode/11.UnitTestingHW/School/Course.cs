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
    public class Course
    {
        private string name = String.Empty;
        private List<Student> students = new List<Student>();

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != null && value != String.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The course name is missing or it is empty", "name");
                }
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                if (value != null)
                {
                    if (value.Count < 30)
                    {
                        this.students = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("The set of students must contain less than 30 students");
                    }
                }
                else
                {
                    throw new ArgumentNullException("students", "The list reference is null");
                }
            }
        }

        public Course(string name,List<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count + 1 < 30)
            {
                int index = this.Students.FindIndex(stud => stud.UniqueNumber.Equals(student.UniqueNumber));
                if (index == -1)
                {
                    this.Students.Add(student);
                }
            }
            else
            {
                throw new InvalidOperationException("Course is full");
            }
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }
    }
}
