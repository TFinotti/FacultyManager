using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_301041366;

namespace MainForm
{
    public partial class AddFaculty : Form
    {

        #region CONSTRUCTOR

        /// <summary>
        /// Defautl constructor
        /// </summary>
        public AddFaculty()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENT HANDLING METHODS

        /// <summary>
        /// Creates a new Faculty object, sets all its fields
        /// based on user's inputs, and adds it to the list of faculties of the Main Form
        /// when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickOK(object sender, EventArgs e)
        {
            // Creates a new Faculty object
            Faculty _faculty = new Faculty();
            // Sets the fields according to user's inputs
            _faculty.Name = _txtName.Text;
            _faculty.Address = new Address(_txtStreet.Text, _txtCity.Text, _txtProvince.Text);
            _faculty.TelephonNumber = long.Parse(_txtTel.Text);
            _faculty.AddEmail(_txtEmail.Text);
            _faculty.StartOfEmployment = _dtpStartDate.Value;
            // Clear the fields for the next entry
            ClearFields();
            // Adds the new Faculty object to the list in the Main Form and closes the window
            MainForm _mainForm = Application.OpenForms["MainForm"] as MainForm;
            _mainForm._faculties.Add(_faculty);
            this.Close();
        }

        /// <summary>
        /// When the button is clicked, it clears the fields
        /// and closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickCancel(object sender, EventArgs e)
        {
            //Clear the fields and closes the window
            ClearFields();
            this.Close();
        }

        /// <summary>
        /// Clear the TextBox and DateTimePicker fields
        /// </summary>
        public void ClearFields()
        {
            // Goes through the controls of the form and selects the TextBoxes and DateTimePickers
            foreach (Control control in Controls)
            {
                if (control is TextBox || control is DateTimePicker)
                {
                    //Sets the input to empty
                    control.Text = "";
                }
            }
        }

        #endregion
    }
}
