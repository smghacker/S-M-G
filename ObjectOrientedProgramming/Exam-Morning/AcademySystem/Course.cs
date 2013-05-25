using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private List<string> topics = new List<string>();

        public List<string> Topics 
        {
            get
            {
                return this.topics;
            }
            protected set
            {
                if (value != null)
                {
                    this.topics = value;
                }
                else
                {
                    throw new ArgumentNullException("Topics are missing");
                }
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public virtual void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse: ");
            result.Append(String.Format("Name={0}; ", this.Name));

            if (this.Teacher != null && this.Teacher.Name != String.Empty)
            {
                result.Append(String.Format("Teacher={0}; ", this.Teacher.Name));
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
            
            return result.ToString();
        }
    }
}