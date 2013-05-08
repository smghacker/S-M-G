using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public static class CourseToString<T> where T: LocalCourse
    {
        public static string courseString<T>(T a) where T : LocalCourse
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse: ");
            result.Append(String.Format("Name={0}; ", a.Name));
            if (a.TeacherName != null && a.TeacherName != String.Empty)
            {

                result.Append(String.Format("Teacher={0}; ", a.TeacherName));
            }
            if (a.Topics.Count != 0)
            {
                result.Append(String.Format("Topics=["));
                for (int i = 0; i <a.Topics.Count; i++)
                {
                    if (i == a.Topics.Count - 1)
                    {
                        result.Append(String.Format("{0}",a.Topics[i]));
                    }
                    else
                    {
                        result.Append(String.Format("{0}, ", a.Topics[i]));
                    }
                }
                result.Append("]; ");
            }
            if (a is LocalCourse)
            {
                result.Append(String.Format("Lab={0}", (a as LocalCourse).Lab));
            }
            else if (a is OffsiteCourse)
            {
                result.Append(String.Format("Town={0}", (a as OffsiteCourse).Town));
            }
            
            return result.ToString();
        }
        }
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        //Constructors
        public LocalCourse(string name, string teacherName, string lab)
            :base(name,teacherName)
        {
            this.Lab = lab;
        }
    }
}
