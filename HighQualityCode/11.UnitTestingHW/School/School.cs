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
    public class School
    {
        private List<Student> allStudents = new List<Student>();

        private List<Course> allCourses = new List<Course>();

        public List<Student> AllStudents
        {
            get { return this.allStudents; }
            set
            {
                if (value != null)
                {
                    this.allStudents = value;
                }
                else
                {
                    throw new ArgumentNullException("allStudents", "Students are missing");
                }
            }
        }

        public List<Course> AllCourses
        {
            get { return this.allCourses; }
            set
            {
                if (value != null)
                {
                    this.allCourses = value;
                }
                else
                {
                    throw new ArgumentNullException("allCourses", "Courses are missing");
                }
            }
        }
        
        public School(List<Student> students, List<Course> courses)
        {
            this.AllStudents = students;
            this.AllCourses = courses;
        }

        public void AddStudent(Student student)
        {
            int index = this.allStudents.FindIndex(stud => stud.UniqueNumber.Equals(student.UniqueNumber));
            if (index == -1)
            {
                this.allStudents.Add(student);
            }
            else
            {
                throw new ArgumentException("Student with id" + student.UniqueNumber + "Exists","student.UniqueNumber");
            }

        }

        public void AddCourse(Course course)
        {
            int index = this.allCourses.FindIndex(cour => cour.Name.Equals(course.Name));
            if (index == -1)
            {
                this.allCourses.Add(course);
            }
            else
            {
                throw new ArgumentException("Course with name" + course.Name+"already exists", "course");
            }
        }


        public void RemoveStudent(Student student)
        {
            this.AllStudents.Remove(student);
        }

        public void RemoveCourse(Course course)
        {
            this.AllCourses.Remove(course);
        }
    }
}
