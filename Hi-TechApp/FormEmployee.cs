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
using Hi_TechLibrary.VALIDATION;

namespace Hi_TechApp
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            PopulatePositionsComboBox();
            PopulateUserRoleComboBox();
        }

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

        private void PopulateUserRoleComboBox()
        {
            cmbBoxUserRole.Items.Clear();
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                cmbBoxUserRole.Items.Add(Utilities.GetEnumDescription(role));
            }
            cmbBoxUserRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxUserRole.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBoxUserRole.SelectedIndex = -1;
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

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
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
            string employeeIdInput = txtBoxEmployeeId.Text.Trim();
            string firstNameInput = txtBoxFirstName.Text.Trim();
            string lastNameInput = txtBoxLastName.Text.Trim();
            string emailInput = txtBoxEmail.Text.Trim();
            string phoneNumberInput = txtBoxPhoneNumber.Text.Trim();

            // Call method to search by Employee ID (highest priority)
            if (!string.IsNullOrEmpty(employeeIdInput) && Validator.IsValidID(employeeIdInput))
            {
                SearchByEmployeeId(employeeIdInput);
                return;
            }
            // Call method to search by Email (second priority)
            if (!string.IsNullOrEmpty(emailInput) && Validator.IsValidEmail(emailInput))
            {
                SearchByEmployeeEmail(emailInput);
                return;
            }
            // Call method to search by First and Last Name (third priority)
            // Fills the grid view with the results
            if (!string.IsNullOrEmpty(firstNameInput) && !string.IsNullOrEmpty(lastNameInput))
            {
                SearchByEmployeeFullName(firstNameInput, lastNameInput);
                return;
            }
            // Call method to search by First Name or Last Name or Phone Number (lowest priority)
            // Fills the grid view with the results of all the searches
            if (!string.IsNullOrEmpty(firstNameInput) || !string.IsNullOrEmpty(lastNameInput) || !string.IsNullOrEmpty(phoneNumberInput))
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
        }

        // Search employee by id
        private void SearchByEmployeeId(string employeeIdInput)
        {
            int employeeId = Convert.ToInt32(employeeIdInput);
            Employee employee = new Employee().SearchEmployeeById(employeeId);
            if (employee != null)
            {
                txtBoxFirstName.Text = employee.FirstName;
                txtBoxLastName.Text = employee.LastName;
                txtBoxEmail.Text = employee.Email;
                txtBoxPhoneNumber.Text = employee.PhoneNumber;
                cmbBoxPosition.SelectedValue = employee.PositionID;
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
                txtBoxEmployeeId.Text = employee.EmployeeID.ToString();
                txtBoxFirstName.Text = employee.FirstName;
                txtBoxLastName.Text = employee.LastName;
                txtBoxPhoneNumber.Text = employee.PhoneNumber;
                cmbBoxPosition.SelectedValue = employee.PositionID;
            }
            else
            {
                MessageBox.Show("Employee email not found", "Search Employee");
            }
        }

        // Search employee by full name
        private void SearchByEmployeeFullName(string firstNameInput, string lastNameInput)
        {
            List<Employee> employees = new Employee().SearchEmployees(firstNameInput, lastNameInput);
            DisplaySearchResults(employees);
        }


        // Search employee by first name, last name or phone number
        private void SearchByEmployeeInput(string input)
        {
            List<Employee> employees = new Employee().SearchEmployees(input);
            DisplaySearchResults(employees);
        }

        private void DisplaySearchResults(List<Employee> employees)
        {
            if (employees.Any(emp => emp != null))
            {
                dataGridViewEmployees.DataSource = employees.Where(emp => emp != null).ToList();
            }
            else
            {
                MessageBox.Show("No employees found", "Search Result");
                dataGridViewEmployees.DataSource = null;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (cmbBoxUserRole.SelectedIndex >= 0) // Ensure a UserRole is selected
            {
                UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), cmbBoxUserRole.SelectedItem.ToString());
                UserAccount userAccount = new UserAccount
                {
                    Username = txtBoxUsername.Text.Trim(),
                    Password = txtBoxPassword.Text.Trim(),
                    UserRole = selectedRole,
                    StatusID = 1, // Default status is Active
                    MustChangePassword = true // New users must change their password
                };
                userAccount.SaveUserAccount(userAccount);
                MessageBox.Show("User account saved successfully", "Save User Account");
            }
            else
            {
                MessageBox.Show("Please select a user role.", "User Role Required");
            }
        }
    }
}
