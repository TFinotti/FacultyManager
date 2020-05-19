using A2_301041366;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AddAssignment : Form
    {
        #region FIELDS

        /// <summary>
        /// Creates the list of available courses and assigned courses
        /// </summary>
        internal List<TeachingCourse> _courses = new List<TeachingCourse>();
        internal List<TeachingCourse> _assignedCourses = new List<TeachingCourse>();

        /// <summary>
        /// Creates the available courses
        /// </summary>
        Course course1 = new Course(CourseSubject.COMP, 120, "Programming 1");
        Course course2 = new Course(CourseSubject.COMP, 228, "Introduction to Java");
        Course course3 = new Course(CourseSubject.CECP, 101, "PC Hardware");
        Course course4 = new Course(CourseSubject.CECP, 257, "The Physical Layer");
        Course course5 = new Course(CourseSubject.BSAF, 100, "Introduction to Business");
        Course course6 = new Course(CourseSubject.BSAF, 320, "Project Management");

        // Creates a semester to add the available courses
        Semester _semester = new Semester(SemesterTime.FALL, 2019);

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddAssignment()
        {
            InitializeComponent();
            // Adds allthe available courses to the semester
            _semester.AddTeachingCourse(course1, new DateTime(2019, 9, 3), new DateTime(2019, 12, 16));
            _semester.AddTeachingCourse(course2, new DateTime(2019, 9, 4), new DateTime(2019, 12, 17));
            _semester.AddTeachingCourse(course3, new DateTime(2019, 9, 5), new DateTime(2019, 12, 18));
            _semester.AddTeachingCourse(course4, new DateTime(2019, 9, 6), new DateTime(2019, 12, 19));
            _semester.AddTeachingCourse(course5, new DateTime(2019, 9, 7), new DateTime(2019, 12, 20));
            _semester.AddTeachingCourse(course6, new DateTime(2019, 9, 8), new DateTime(2019, 12, 21));
            // Populates the list of available courses
            foreach (var item in _semester.CoursesOffered)
            {
                if (item != null)
                {
                    _courses.Add(item);
                    _ckdlstCourses.Items.Add(item);
                }
            }
        }

        #endregion

        #region EVENT HANDLING METHODS

        /// <summary>
        /// Clears the checked items, the list of assigned courses,
        /// and closes the window whe the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickCancel(object sender, EventArgs e)
        {
            this._lstAssign.Items.Clear();
            ClearChecks();
            this.Close();
        }

        /// <summary>
        /// When the button is clicked, it adds all the assigned courses
        /// to the faculty selected in the Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickOK(object sender, EventArgs e)
        {
            // Opens the Main Form
            MainForm _mainForm = Application.OpenForms["MainForm"] as MainForm;
            // Takes all the courses added to the new assignment and assign them to the selected faculty in the Main Form
            foreach (var item in _assignedCourses)
            {
                foreach (Faculty faculty in _mainForm._faculties)
                {
                    if (_mainForm._lstFaculty.SelectedItem == faculty)
                    {
                        faculty.AddQualifiedCourse(item);
                    }
                }
            }
            // Clears the checked items, the list of assigned courses,
            // and closes the window when the button is clicked 
            this._lstAssign.Items.Clear();
            ClearChecks();
            this.Close();
        }

        /// <summary>
        /// When the button is clicked, it adds all the checked available courses
        /// to the new assignment list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickAddCourses(object sender, EventArgs e)
        {
            // Adds the check items to the assigned courses list
            _assignedCourses = _ckdlstCourses.CheckedItems.OfType<TeachingCourse>().ToList();
            //Updates the list after each iteration
            _lstAssign.Items.Clear();
            foreach (var item in _assignedCourses)
            {
                if (item != null)
                {
                    _lstAssign.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Clear the check items
        /// </summary>
        private void ClearChecks()
        {
            for (int i = 0; i < _ckdlstCourses.Items.Count; i++)
            {
                _ckdlstCourses.SetItemChecked(i, false);
            }
        }

        #endregion
    }
}
