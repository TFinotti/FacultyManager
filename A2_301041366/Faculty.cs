using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    [Serializable]
    public class Faculty
    {
        private int employeeNumber;
        private string name;
        private DateTime startOfEmployment;
        private long telephonNumber;
        [JsonProperty]
        private readonly List<string> emailAddress = new List<string>();
        [JsonProperty]
        private readonly List<TeachingCourse> courses = new List<TeachingCourse>();
        private Address address;

        public Faculty()
        {
            EmployeeNumber = FacultyIDService.GetNewId();
        }

        public Faculty(string name, Address address, long telNumber)
        {
            EmployeeNumber = FacultyIDService.GetNewId();
            Name = name;
            Address = address;
            TelephonNumber = telNumber;
        }

        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime StartOfEmployment
        {
            get { return startOfEmployment; }
            set { startOfEmployment = value; }
        }

        public long TelephonNumber
        {
            get { return telephonNumber; }
            set { telephonNumber = value; }
        }
        public List<string> EmailAddress
        {
            get { return emailAddress; }
        }

        public void AddEmail(string email)
        {
            emailAddress.Add(email);
        }
        public List<TeachingCourse> Courses
        {
            get { return courses; }
        }
        public void AddQualifiedCourse(TeachingCourse course)
        {
            courses.Add(course);
        }

        public bool IsQualified(string courseCode)
        {
            bool result = true;

            /*for (int i = 0; i < courses.Count; i++)
            {
                if (Courses[i].CourseCode == courseCode)
                {
                    result = true;
                }
            }*/

            return result;
        }

        public string GetInfo()
        {
            string result = $"Emp#: {EmployeeNumber}, {Name}, Started: {StartOfEmployment.ToString("yyyy-MM-dd")}\nAddress: {Address.StreetAddress}, {Address.City}, {Address.Province}, Tel.: {TelephonNumber}\nEmails:";
            for (int i = 0; i < emailAddress.Count; i++)
            {
                result += "\n\t" + EmailAddress[i];
            }
            result += "\nCourses teaching:";
            for (int i = 0; i < courses.Count; i++)
            {
                result += "\n\t" + courses[i].CourseCode + " " + courses[i].CourseTitle;
            }
            result += "\n";
            return result;
        }

        public override string ToString()
        {
            return $"Emp#: {EmployeeNumber}         Faculty: {Name}";
        }
    }
}
