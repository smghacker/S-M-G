using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolNS;
using System.Collections.Generic;

namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseNameRegularTest()
        {
            Course course = new Course("C#", new List<Student>());
            Assert.AreEqual("C#", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        //The same case is when we have null
        public void CourseNameEmptyStringTest()
        {
            Course course = new Course("", new List<Student>());
        }

        [TestMethod]
        public void CourseStudentsPropertyRegularTest()
        {
            List<Student> students = new List<Student>();
            Student student = new Student("Svetlin", 11111);
            students.Add(student);
            Course course = new Course("C#", students);
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void CourseStudentsPropertyMoreThan30Test()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 40; i++)
            {
                Student student = new Student("Svetlin"+i, 11100+i);
                students.Add(student);
            }
            Course course = new Course("C#", students);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void CourseStudentsPropertyNullTest()
        {
            Course course = new Course("C#", null);
        }

        [TestMethod]
        public void CourseAddStudentRegularTest()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);
            Student student1 = new Student("Joro", 11112);
            course.AddStudent(student);
            course.AddStudent(student1);
            Assert.AreEqual(2, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CourseAddStudentAlreadyInTheCourseTest()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);
            Student student1 = new Student("Svetlin", 11111);
            course.AddStudent(student);
            course.AddStudent(student1);
            Assert.AreEqual(1,course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void CourseAddStudentWhenTheCourseIsFullTest()
        {
            Course course = new Course("C#", new List<Student>());
            for (int i = 0; i < 40; i++)
            {
                Student student = new Student("Svetlin" + i, 11100 + i);
                course.AddStudent(student);
            }
        }

        [TestMethod]
        public void CourseRemoveStudentRegularTest()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        //This is the same case when we want to remove student that doesn't exists
        public void CourseRemoveStudentWhenTheListIsEmpty()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }
    }
}
