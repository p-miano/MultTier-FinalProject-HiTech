using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechLibrary.BLL;

namespace Hi_TechApp
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtBoxFirstName.Text.Trim();
            employee.LastName = txtBoxLastName.Text.Trim();
            employee.Email = txtBoxEmail.Text.Trim();
            employee.PhoneNumber = txtBoxPhoneNumber.Text.Trim();
            employee.PositionID = Convert.ToInt32(txtBoxPosition.Text.Trim());
            MessageBox.Show("Employee record saved successfully", "Save Employee");
        }
    }
}
