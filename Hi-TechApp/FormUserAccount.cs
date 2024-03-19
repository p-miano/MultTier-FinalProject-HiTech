﻿using Hi_TechLibrary.BLL;
using Hi_TechLibrary.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_TechApp
{
    public partial class FormUserAccount : Form
    {
        private int? employeeId;

        #region Initialization
        public FormUserAccount()
        {
            InitializeComponent();
            PopulateUserRoleComboBox();
        }
        // Overloaded constructor to receive the employeeId from the Employee form
        public FormUserAccount(int employeeId)
        {
            this.employeeId = employeeId;
            InitializeComponent();
            FillEmployeeInfo(employeeId);
            FillUserAccountInfo(employeeId);
        }
        private void FillEmployeeInfo(int employeeId)
        {
            Employee employee = new Employee().SearchEmployeeById(employeeId);
            if (employee != null)
            {
                txtBoxEmployeeId.Text = employee.EmployeeID.ToString();
                txtBoxFirstName.Text = employee.FirstName;
                txtBoxLastName.Text = employee.LastName;
                txtBoxEmail.Text = employee.Email;
                Position position = new Position();
                txtBoxPosition.Text = position.GetPositionById(employee.PositionID);
            }
        }
        private void FillUserAccountInfo(int employeeId)
        {
            UserAccount userAccount = new UserAccount().SearchUserAccountById(employeeId);
            if (userAccount != null)
            {
                txtBoxUserId.Text = userAccount.UserID.ToString();
                txtBoxUsername.Text = userAccount.Username;
                PopulateUserRoleComboBox();

                // Find and select the current user role in the ComboBox
                foreach (var item in cmbBoxUserRole.Items)
                {
                    if (item.ToString() == Utilities.GetEnumDescription(userAccount.UserRole))
                    {
                        cmbBoxUserRole.SelectedItem = item;
                        break;
                    }
                }
            }
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
        #endregion

        #region Buttons
        private void btnAddNewUserAccount_Click(object sender, EventArgs e)
        {
            if (!ValidateUserAccountInput())
            {
                return;
            }
            if (txtBoxUsername.Text.Trim() != string.Empty)
            {
                if (cmbBoxUserRole.SelectedIndex >= 0) // Ensure a UserRole is selected
                {
                    // Retrieve the selected item, convert it to string, and remove spaces
                    string roleWithoutSpaces = cmbBoxUserRole.SelectedItem.ToString().Replace(" ", "");
                    // Parse the modified string to the UserRole enum
                    UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), roleWithoutSpaces);
                    UserAccount userAccount = new UserAccount
                    {
                        EmployeeID = Convert.ToInt32(txtBoxEmployeeId.Text.Trim()),
                        Username = txtBoxUsername.Text.Trim(),
                        Password = UserAccount.GenerateRandomPassword(),
                        UserRole = selectedRole,
                        StatusID = 1, // Default status is Active
                        MustChangePassword = true // New users must change their password
                    };
                    userAccount.SaveUserAccount(userAccount);
                    MessageBox.Show("User account saved successfully. A temporary password was created and needs to be changed at first login.", "Save User Account");
                }
                else
                {
                    MessageBox.Show("Please select a user role.", "User Role Required");
                }
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // UserAccount search fields
            string userIdInput = txtBoxUserId.Text.Trim();
            string usernameInput = txtBoxUsername.Text.Trim();
            string userRoleInput = cmbBoxUserRole.Text.Trim();
            // Call method to search by User ID (highest priority)
            if (!string.IsNullOrEmpty(userIdInput))
            {
                if (Validator.IsValidID(userIdInput))
                {
                    SearchUserAccountByUserId(userIdInput);
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid User ID. Please enter a numeric value.", "Validation Error");
                    txtBoxUserId.Focus();
                    return;
                }
            }
            // Call method to search by Username (second priority)
            else if (!string.IsNullOrEmpty(usernameInput))
            {
                if (Validator.isValidUsername(usernameInput))
                {
                    SearchUserAccountByUsername(usernameInput);
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Username. Please enter a valid username.", "Validation Error");
                    txtBoxUsername.Focus();
                    return;
                }
            }
            // Call method to search by UserRole (third priority). Returns a list of users.
            else if (!string.IsNullOrEmpty(userRoleInput))
            {
                SearchUserAccountByUserRole(userRoleInput);
            }
            else
            {
                MessageBox.Show("Please enter an information to search", "Search User Account");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateUserAccountInput())
            {
                return;
            }
            if (!string.IsNullOrEmpty(txtBoxUserId.Text.Trim()))
            {
                int userId = Convert.ToInt32(txtBoxUserId.Text.Trim());
                UserAccount userAccount = new UserAccount().SearchUserAccountById(userId);
                if (userAccount != null)
                {
                    userAccount.Username = txtBoxUsername.Text.Trim();
                    userAccount.UserRole = (UserRole)Enum.Parse(typeof(UserRole), cmbBoxUserRole.SelectedItem.ToString().Replace(" ", ""));
                    userAccount.DateModified = DateTime.Now;
                    userAccount.UpdateUserAccount(userAccount);
                    MessageBox.Show("User account updated successfully", "Update User Account");
                }
                else
                {
                    MessageBox.Show("User Account ID not found", "Update User Account");
                }
            }
            else
            {
                MessageBox.Show("User Account ID not found", "Update User Account");
            }

        }

        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            UserAccount userAccount = new UserAccount();
            userAccount.UserID = Convert.ToInt32(txtBoxUserId.Text.Trim());
            if (MessageBox.Show("Are you sure you want to delete this account from the database?", "Delete User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                userAccount.DeleteUserAccount(userAccount.UserID);
                MessageBox.Show("User account deleted successfully", "Delete User Account");
                ClearAll();
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnListAllUsers_Click(object sender, EventArgs e)
        {
            List<UserAccount> userAccounts = new UserAccount().GetAllUserAccounts();
            DisplaySearchResults(userAccounts);

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

        #region Search
        // Search user account by user id
        private void SearchUserAccountByUserId(string userIdInput)
        {
            int userId = Convert.ToInt32(userIdInput);
            UserAccount userAccount = new UserAccount().SearchUserAccountById(userId);
            if (userAccount != null)
            {
                employeeId = userAccount.EmployeeID; // Update the employeeId global variable
                UpdateUserAccountInfoUI(userAccount);
                FillEmployeeInfo(employeeId.Value);
            }
            else
            {
                MessageBox.Show("User Account ID not found", "Search User Account");
            }
        }
        // Search user account by username
        private void SearchUserAccountByUsername(string usernameInput)
        {
            UserAccount userAccount = new UserAccount().SearchUserAccountByUsername(usernameInput);
            if (userAccount != null)
            {
                employeeId = userAccount.EmployeeID;
                UpdateUserAccountInfoUI(userAccount);
                FillEmployeeInfo(employeeId.Value);
            }
            else
            {
                MessageBox.Show("Username not found", "Search User Account");
            }
        }
        // Search user account by UserRole
        private void SearchUserAccountByUserRole(string userRoleInput)
        {
            userRoleInput = userRoleInput.Replace(" ", "");
            UserRole selectedRole = (UserRole)Enum.Parse(typeof(UserRole), userRoleInput);
            List<UserAccount> userAccounts = new UserAccount().SearchUserAccountByUserRole(selectedRole);
            DisplaySearchResults(userAccounts);
        }
        #endregion

        #region Form Utilities
        private void ClearAll()
        {
            txtBoxUserId.Clear();
            txtBoxUsername.Clear();
            cmbBoxUserRole.SelectedIndex = -1;
            dtGridUserAccounts.DataSource = null;
        }
        private bool ValidateUserAccountInput()
        {
            if (!Validator.isValidUsername(txtBoxUsername.Text.Trim()))
            {
                MessageBox.Show("Invalid Username. Please enter a valid username.", "Validation Error");
                txtBoxUsername.Focus();
                return false;
            }
            return true;
        }
        private void UpdateUserAccountInfoUI(UserAccount userAccount)
        {
            txtBoxUserId.Text = userAccount.UserID.ToString();
            txtBoxUsername.Text = userAccount.Username;
            cmbBoxUserRole.SelectedItem = Utilities.GetEnumDescription(userAccount.UserRole);
        }

        private void DisplaySearchResults(List<UserAccount> userAccounts)
        {
            if (userAccounts.Any(user => user != null))
            {
                dtGridUserAccounts.DataSource = userAccounts.Where(user => user != null).ToList();
            }
            else
            {
                MessageBox.Show("No users found", "Search Result");
                dtGridUserAccounts.DataSource = null;
            }
        }
        #endregion
    }
}
