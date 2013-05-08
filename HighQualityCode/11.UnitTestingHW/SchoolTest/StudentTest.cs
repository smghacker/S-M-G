using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolNS;
using System.Collections.Generic;

namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentNameAndUniqueNumberRegularTest()
        {
            Student student = new Student("Svetlin", 11111);

            Assert.AreEqual("Svetlin", student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        //The same case is when we have null
        public void StudentNameStringEmptyTest()
        {
            Student student = new Student("", 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void StudentUniqueNumberOutOfRangeSmallerTest()
        {
            Student student = new Student("Svetlin", 111);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void StudentUniqueNumberOutOfRangeBiggerTest()
        {
            Student student = new Student("Svetlin", 111111111);
        }

        [TestMethod]
        public void StudentJoinCourseRegularTest()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);

            student.JoinCourse(course);

            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        public void StudentLeaveCourseRegularTest()
        {
            Course course = new Course("C#", new List<Student>());
            Student student = new Student("Svetlin", 11111);
            
            student.JoinCourse(course);
            student.LeaveCourse(course);

            Assert.AreEqual(0, course.Students.Count);
        }
    }
}
