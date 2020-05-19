using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    public class FacultyRepository : RepositoryBase
    {
        public FacultyRepository() { }
        public override List<Faculty> Faculties
        {
            get { return faculties; }
        }

        public void Add(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        /// <summary>
        /// Method to query all the faculties without any assignments,
        /// ordered alphabetically by their last name, using LINQ dot notation
        /// </summary>
        /// <param name="_faculties"></param>
        /// <returns></returns>
        public IEnumerable<Faculty> ListFacultiesNotAssgn(ref List<Faculty> _faculties)
        {
            var _facultiesNotAssgn = _faculties
                                     .Where(_faculty => _faculty.Courses.Count == 0)
                                     .OrderBy(_faculty => _faculty.Name.Split(new char[] { ' ' })[1]);
            return _facultiesNotAssgn;
        }

        /// <summary>
        /// Method to query the faculty assigned to a course
        /// mataching a course code inputed by the user, using LINQ query notation
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="_faculties"></param>
        /// <returns></returns>
        public IEnumerable<Faculty> ListFacultyAssgn(string courseCode, ref List<Faculty> _faculties)
        {
            var _facultyAssgn = from _faculty in _faculties
                                from _course in _faculty.Courses
                                where _course.CourseCode == courseCode
                                select _faculty;
            return _facultyAssgn;
        }
    }
}
