using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Hi_TechLibrary.BLL;
using Hi_TechLibrary.VALIDATION;

namespace Hi_TechApp
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            PopulatePositionsComboBox();
            
        }

        #region Buttons
        private void btnLinkUserAccount_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(txtBoxEmployeeId.Text.Trim());
            UserAccount userAccount = new UserAccount().SearchUserAccountById(employeeId);
            if (userAccount != null)
            {
                this.Close();
                FormUserAccount formUserAccount = new FormUserAccount(employeeId);
                formUserAccount.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to create a user account associated with this employer?", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    FormUserAccount formUserAccount = new FormUserAccount(employeeId);
                    formUserAccount.ShowDialog();
                }
            }
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (!ValidateEmployeeInput())
            {
                return;
            }
            if (cmbBoxPosition.SelectedIndex >= 0) // Ensure a position is selected
            {
                int selectedPositionID = ((KeyValuePair<int, string>)cmbBoxPosition.SelectedItem).Key;
                Employee employee = new Employee
                {
                    FirstName = txtBoxFirstName.Text.Trim(),
                    LastName = txtBoxLastName.Text.Trim(),
                    Email = txtBoxEmail.Text.Trim(),
                    PhoneNumber = txtBoxPhoneNumber.Text.Trim(),
                    PositionID = selectedPositionID // Set the selected PositionID
                };
                employee.SaveEmployee(employee);
                MessageBox.Show("Employee record saved successfully", "Save Employee");
            }
            else
            {
                MessageBox.Show("Please select a position.", "Position Required");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Employee search fields
            string employeeIdInput = txtBoxEmployeeId.Text.Trim();
            string firstNameInput = txtBoxFirstName.Text.Trim();
            string lastNameInput = txtBoxLastName.Text.Trim();
            string emailInput = txtBoxEmail.Text.Trim();
            string phoneNumberInput = txtBoxPhoneNumber.Text.Trim();
            string positionInput = cmbBoxPosition.Text.Trim();

            // Call method to search by Employee ID (highest priority)
            if (!string.IsNullOrEmpty(employeeIdInput))
            {
                if (Validator.IsValidID(employeeIdInput))
                {
                    SearchByEmployeeId(employeeIdInput);
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID. Please enter a numeric value.", "Validation Error");
                    txtBoxEmployeeId.Focus();
                    return;
                }
            }
            // Call method to search by Email (third priority)
            else if (!string.IsNullOrEmpty(emailInput))
            {
                if (Validator.IsValidEmail(emailInput))
                {
                    SearchByEmployeeEmail(emailInput);
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Email format. Please enter a valid email.", "Validation Error");
                    txtBoxEmail.Focus();
                    return;
                }
            }
            // Call method to search by First and Last Name. Fills the grid view with the results
            else if (!string.IsNullOrEmpty(firstNameInput) && !string.IsNullOrEmpty(lastNameInput))
            {
                SearchByEmployeeFullName(firstNameInput, lastNameInput);
                return;
            }
            // Call method to search by Position. Fills the grid view with the results
            else if (!string.IsNullOrEmpty(positionInput))
            {
                SearchByEmployeePosition(positionInput);
                return;
            }
            // Call method to search by First Name or Last Name or Phone Number. Fills the grid view with the results
            else if (!string.IsNullOrEmpty(firstNameInput) || !string.IsNullOrEmpty(lastNameInput) || !string.IsNullOrEmpty(phoneNumberInput))
            {
                if (!string.IsNullOrEmpty(firstNameInput))
                {
                    SearchByEmployeeInput(firstNameInput);
                }
                else if (!string.IsNullOrEmpty(lastNameInput))
                {
                    SearchByEmployeeInput(lastNameInput);
                }
                else if (!string.IsNullOrEmpty(phoneNumberInput))
                {
                    SearchByEmployeeInput(phoneNumberInput);
                }
            }
            else
            {
                MessageBox.Show("Please enter an information to search", "Search Employee");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (!ValidateEmployeeInput())
            {
                return;
            }
            int employeeId = Convert.ToInt32(txtBoxEmployeeId.Text.Trim());
            Hi_TechLibrary.BLL.Employee employee = new Hi_TechLibrary.BLL.Employee().SearchEmployeeById(employeeId);
            if (employee != null)
            {
                employee.FirstName = txtBoxFirstName.Text.Trim();
                employee.LastName = txtBoxLastName.Text.Trim();
                employee.Email = txtBoxEmail.Text.Trim();
                employee.PhoneNumber = txtBoxPhoneNumber.Text.Trim();
                employee.PositionID = ((KeyValuePair<int, string>)cmbBoxPosition.SelectedItem).Key;
                employee.UpdateEmployee(employee);
                MessageBox.Show("Employee record updated successfully", "Update Employee");
            }
            else
            {
                MessageBox.Show("Employee ID not found", "Update Employee");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = Convert.ToInt32(txtBoxEmployeeId.Text.Trim());
            if (MessageBox.Show("Are you sure you want to delete this employee from the database?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                employee.DeleteEmployee(employee.EmployeeID);
                MessageBox.Show("Employee record deleted successfully", "Confirmation", MessageBoxButtons.OK);
                ClearAll();
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnListAllEmployees_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new Employee().GetAllEmployees();
            DisplaySearchResults(employees);
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
        #endregion

        #region Form Utlities

        private void PopulatePositionsComboBox()
        {
            // Clear existing items to avoid duplication
            cmbBoxPosition.Items.Clear();
            // Fetch all positions
            List<Position> positions = new Position().GetAllPositions();
            // Use a Dictionary to hold the PositionID as Key and Title as Value
            Dictionary<int, string> positionDictionary = new Dictionary<int, string>();
            foreach (var position in positions)
            {
                // Add Position Title as the display member
                positionDictionary.Add(position.PositionID, position.PositionTitle);
            }
            // Enable autocomplete
            cmbBoxPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxPosition.AutoCompleteSource = AutoCompleteSource.ListItems;
            // Set the combobox DataSource to the dictionary
            cmbBoxPosition.DataSource = new BindingSource(positionDictionary, null);
            cmbBoxPosition.DisplayMember = "Value";
            cmbBoxPosition.ValueMember = "Key";
            // Set the SelectedIndex to -1 to show the ComboBox as empty
            cmbBoxPosition.SelectedIndex = -1;
        }
        private void UpdateEmployeeInfoUI(Employee employee)
        {
            ClearAll();
            txtBoxEmployeeId.Text = employee.EmployeeID.ToString();
            txtBoxFirstName.Text = employee.FirstName;
            txtBoxLastName.Text = employee.LastName;
            txtBoxEmail.Text = employee.Email;
            txtBoxPhoneNumber.Text = employee.PhoneNumber;
            cmbBoxPosition.SelectedValue = employee.PositionID;
        }
        private void ClearAll()
        {
            txtBoxEmployeeId.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxEmail.Clear();
            txtBoxPhoneNumber.Clear();
            cmbBoxPosition.SelectedIndex = -1;
            dtGridEmployees.DataSource = null;
        }
        private bool ValidateEmployeeInput()
        {
            // Validate First Name
            if (!Validator.IsValidName(txtBoxFirstName.Text.Trim()))
            {
                MessageBox.Show("Invalid first name.", "Input Error");
                txtBoxFirstName.Focus();
                return false;
            }
            // Validate Last Name
            if (!Validator.IsValidName(txtBoxLastName.Text.Trim()))
            {
                MessageBox.Show("Invalid last name.", "Input Error");
                txtBoxLastName.Focus();
                return false;
            }
            // Validate Email
            if (!Validator.IsValidEmail(txtBoxEmail.Text.Trim()))
            {
                MessageBox.Show("Invalid email address.", "Input Error");
                txtBoxEmail.Focus();
                return false;
            }            
            // All validations passed
            return true;
        }
        #endregion

        #region Search
        // Search employee by id
        private void SearchByEmployeeId(string employeeIdInput)
        {
            int employeeId = Convert.ToInt32(employeeIdInput);
            Employee employee = new Employee().SearchEmployeeById(employeeId);
            if (employee != null)
            {
                UpdateEmployeeInfoUI(employee);
            }
            else
            {
                MessageBox.Show("Employee ID not found", "Search Employee");
            }
        }
        // Search employee by email
        private void SearchByEmployeeEmail(string emailInput)
        {
            Employee employee = new Employee().SearchEmployeeByEmail(emailInput);
            if (employee != null)
            {
                UpdateEmployeeInfoUI(employee);
            }
            else
            {
                MessageBox.Show("Employee email not found", "Search Employee");
            }
        }
        // Search by employee position
        private void SearchByEmployeePosition(string positionInput)
        {
            int positionID = ((KeyValuePair<int, string>)cmbBoxPosition.SelectedItem).Key;
            List<Employee> employees = new Employee().SearchEmployeesByPosition(positionID);
            DisplaySearchResults(employees);
        }
        // Search employee by full name
        private void SearchByEmployeeFullName(string firstNameInput, string lastNameInput)
        {
            List<Employee> employees = new Employee().SearchEmployees(firstNameInput, lastNameInput);
            DisplaySearchResults(employees);
        }
        // Search employee by first name, last name, phone number or position
        private void SearchByEmployeeInput(string input)
        {
            List<Employee> employees = new Employee().SearchEmployees(input);
            DisplaySearchResults(employees);
        }
        // Display search results in the DataGridView
        private void DisplaySearchResults(List<Employee> employees)
        {
            if (employees.Any(emp => emp != null))
            {
                dtGridEmployees.DataSource = employees.Where(emp => emp != null).ToList();
            }
            else
            {
                MessageBox.Show("No employees found", "Search Result");
                dtGridEmployees.DataSource = null;
            }
        }
        #endregion
    }
}
