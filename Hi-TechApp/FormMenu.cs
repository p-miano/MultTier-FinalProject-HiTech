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
using Hi_TechLibrary.DAL;

namespace Hi_TechApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployee employeeForm = new FormEmployee(); 
            employeeForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUserAccount userForm = new FormUserAccount();
            userForm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomer customerForm = new FormCustomer();
            customerForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the form with confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
