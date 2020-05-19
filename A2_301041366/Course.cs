using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    [Serializable]
    public enum CourseSubject { COMP, BSAF, CECP };
    public class Course
    {
        protected int number;
        protected string title;
        protected CourseSubject subject;
        private readonly string courseCode;

        public Course() { }

        public Course(CourseSubject subject, int number, string title)
        {
            Number = number;
            Title = title;
            Subject = subject;
            courseCode = subject + $"{Number}";
        }

        public CourseSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string CourseCode
        {
            get { return subject + $"{Number}"; }
        }

        public virtual string GetInfo()
        {
            return $"{CourseCode} {Title}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
