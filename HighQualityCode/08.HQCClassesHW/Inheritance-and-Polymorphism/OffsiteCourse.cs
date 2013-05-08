using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name,string teacherName,string town)
            : base(name, teacherName)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse: "); 
            result.Append(String.Format("Name={0}; ", this.Name));
            if (this.TeacherName != null && this.TeacherName != String.Empty)
            {

                result.Append(String.Format("Teacher={0}; ", this.TeacherName));
            }
            if (this.Topics.Count != 0)
            {
                result.Append(String.Format("Topics=["));
                for (int i = 0; i < this.Topics.Count; i++)
                {
                    if (i == this.Topics.Count - 1)
                    {
                        result.Append(String.Format("{0}", this.Topics[i]));
                    }
                    else
                    {
                        result.Append(String.Format("{0}, ", this.Topics[i]));
                    }
                }
                result.Append("]; ");
            }

            result.Append(String.Format("Town={0}", this.Town));
            
            return result.ToString();
        }
    }
}
