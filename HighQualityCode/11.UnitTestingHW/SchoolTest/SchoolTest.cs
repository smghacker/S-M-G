using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolNS;
using System.Collections.Generic;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructorRegularTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void SchoolAllStudentsPropertyNullTest()
        {
            School school = new School(null, new List<Course>());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void SchoolAllCoursesPropertyNullTest()
        {
            School school = new School(new List<Student>(), null);
        }

        [TestMethod]
        public void SchoolAddStudentToSchoolRegularTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Student student = new Student("Svetlin", 11111);
            school.AddStudent(student);
            Assert.AreEqual(1, school.AllStudents.Count);
        }

        [TestMethod]
        public void SchoolAddCertainStudentWhoExistsAlreadyTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Student student = new Student("Svetlin", 11111);
            Student student1 = new Student("Svetlin", 11111);
            school.AddStudent(student);
            school.AddStudent(student1);
            Assert.AreEqual(1, school.AllStudents.Count);
        }

        [TestMethod]
        public void SchoolAddCourseToSchoolRegularTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Course course = new Course("C#", new List<Student>());
            school.AddCourse(course);
            Assert.AreEqual(1, school.AllCourses.Count);
        }

        [TestMethod]
        public void SchoolAddCertainCourseWhoExistsAlreadyTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Course course = new Course("C#", new List<Student>());
            Course course1 = new Course("C#", new List<Student>());
            school.AddCourse(course);
            school.AddCourse(course1);
            Assert.AreEqual(1, school.AllCourses.Count);
        }

        [TestMethod]
        public void SchoolRemoveStudentRegularTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Student student = new Student("Svetlin", 11111);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.AreEqual(0, school.AllStudents.Count);
        }

        [TestMethod]
        public void SchoolRemoveCourseRegularTest()
        {
            School school = new School(new List<Student>(), new List<Course>());
            Course course = new Course("C#", new List<Student>());
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(0, school.AllCourses.Count);
        }
    }
}
