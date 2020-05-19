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
    public partial class MainForm : Form
    {
        #region FIELDS

        /// <summary>
        /// Represents the AddFaculty form and the AddAssignment form
        /// </summary>
        private AddFaculty _addFacultyForm;
        private AddAssignment _addAssignForm;
        private FacultyAssignment _facultyAssignmentForm;

        /// <summary>
        /// Creates the list of faculties and the repository
        /// </summary>
        internal List<Faculty> _faculties = new List<Faculty>();
        internal FacultyRepository _repo = new FacultyRepository();

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            // Initialize the secondary forms
            _addFacultyForm = new AddFaculty();
            _addAssignForm = new AddAssignment();
            _facultyAssignmentForm = new FacultyAssignment();
        }

        #endregion

        #region EVENT HANDLING METHODS

        /// <summary>
        /// Opens the Add Faculty form when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickAddFaculty(object sender, EventArgs e)
        {
            // Opens the form as modal window
            _addFacultyForm.ShowDialog();
        }

        /// <summary>
        /// Opens the Add Faculty form when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickAddAssign(object sender, EventArgs e)
        {
            // Opens the form as modal window
            _addAssignForm.ShowDialog();

        }

        /// <summary>
        /// Updates the list of faculties everytime the window is activated,
        /// like when a new faculty is added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnActivatedMainForm(object sender, EventArgs e)
        {
            //Clears the list
            _lstFaculty.Items.Clear();
            //Adds the updated list
            _lstFaculty.Items.AddRange(_faculties.ToArray());
        }

        /// <summary>
        /// Saves the list of faculties i a .json file
        /// when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSave(object sender, EventArgs e)
        {
            // Go through the list of faculties to add them to the repository
            foreach (var item in _faculties)
            {
                if (item != null)
                {
                    _repo.Add(item);
                }
            }
            _repo.Save("FacultyData.json");
            // Shows a messsage to the user confirming the file was saved
            string message = "Faculty and assignments successfully saved!";
            string title = "Success";
            MessageBox.Show(message, title);
        }

        /// <summary>
        /// When a item from the list of faculties is clicked,
        /// it shows the list of courses assigned to the selected faculty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectItem(object sender, EventArgs e)
        {
            //Clears the list
            _lstAssign.Items.Clear();
            // Add the faculty's assigned courses to the list
            foreach (var item in _faculties)
            {
                if (_lstFaculty.SelectedItem == item)
                {
                    for (int i = 0; i < item.Courses.Count; i++)
                    {
                        _lstAssign.Items.Add(item.Courses[i].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// When clicked, it opens a new window with the Faculty Assignment Form,
        /// and shows a list of all faculties without any assignments,
        /// ordered alphabetically by their last name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickNotAssigned(object sender, EventArgs e)
        {
            // Clears the list
            _facultyAssignmentForm._lstResult.Items.Clear();
            // Runs the query
            var _queryResult = _repo.ListFacultiesNotAssgn(ref _faculties);
            // Populates the list
            foreach (var item in _queryResult)
            {
                if (item != null)
                {
                    _facultyAssignmentForm._lstResult.Items.Add(item.ToString());
                }
            }
            // Opens the window with the list
            _facultyAssignmentForm.ShowDialog();
        }

        /// <summary>
        /// When clicked, it opens a new window with the Faculty Assignment Form,
        /// and shows the faculty assignment for the specific course
        /// matching the course code inputed by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSearch(object sender, EventArgs e)
        {
            // Clears the list
            _facultyAssignmentForm._lstResult.Items.Clear();
            // Reads the course code from the text box and sets it to uppercase.
            string _courseCode = _txtCourseCode.Text.ToUpper();
            // Runs the query
            var _queryResult = _repo.ListFacultyAssgn(_courseCode, ref _faculties);
            // Populates the list
            foreach (var item in _queryResult)
            {
                if (item != null)
                {
                    _facultyAssignmentForm._lstResult.Items.Add(item.ToString());
                }
            }
            // Opens the window with the list
            _facultyAssignmentForm.ShowDialog();
        }

        #endregion
    }
}
