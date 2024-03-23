﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechLibrary.BLL;
using System.Data.SqlClient;
using Hi_TechLibrary.DAL;

namespace Hi_TechApp
{
    public partial class FormCustomer : Form
    {
        SqlDataAdapter adapter;
        DataSet dsCustomersDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlCommandBuilder;

        public FormCustomer()
        {
            InitializeComponent();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            PopulateComboBoxStatus();
            SetInitialState();            
            CreateCustomerDataSet();
        }

        #region Buttons
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // TO DO: Validate the input fields
            DataRow newRow = dtCustomers.NewRow();
            newRow["Name"] = txtBoxName.Text.Trim();
            newRow["Street"] = txtBoxStreet.Text.Trim();
            newRow["StreetNumber"] = txtBoxStreetNumber.Text.Trim();
            newRow["City"] = txtBoxCity.Text.Trim();
            newRow["PostalCode"] = txtBoxPostalCode.Text.Trim();
            newRow["PhoneNumber"] = txtBoxPhoneNumber.Text.Trim();
            newRow["FaxNumber"] = txtBoxFaxNumber.Text.Trim();
            newRow["CreditLimit"] = Convert.ToDecimal(txtBoxCreditLimit.Text);
            newRow["StatusID"] = cmbBoxStatus.SelectedValue;
            dtCustomers.Rows.Add(newRow);
            MessageBox.Show("New customer added successfully.", "Add Customer");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TO DO: Validate the input fields
            bool isIdProvided = int.TryParse(txtBoxCustomerId.Text, out int customerID);
            string nameSearch = txtBoxName.Text.Trim();
            // If an ID is provided, search by ID
            if (isIdProvided)
            {
                DataRow row = dtCustomers.Rows.Find(customerID);
                if (row != null)
                {
                    txtBoxCustomerId.Text = row["CustomerID"].ToString();
                    txtBoxName.Text = row["Name"].ToString();
                    txtBoxStreet.Text = row["Street"].ToString();
                    txtBoxStreetNumber.Text = row["StreetNumber"].ToString();
                    txtBoxCity.Text = row["City"].ToString();
                    txtBoxPostalCode.Text = row["PostalCode"].ToString();
                    txtBoxPhoneNumber.Text = row["PhoneNumber"].ToString();
                    txtBoxFaxNumber.Text = row["FaxNumber"].ToString();
                    txtBoxCreditLimit.Text = row["CreditLimit"].ToString();
                    cmbBoxStatus.SelectedValue = row["StatusID"];
                    SetStateAfterSuccessfulSearch();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Search Customer");
                    SetStateAfterListOrFailedSearch();
                }
            }
            // If a name is provided, search by name
            else if (!string.IsNullOrEmpty(nameSearch))
            {
                DataView dv = dtCustomers.DefaultView;
                dv.RowFilter = $"Name LIKE '%{nameSearch}%'";
                dtGridCustomers.DataSource = dv.ToTable();
                SetStateAfterListOrFailedSearch();
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID or a Name to search.", "Search Customer");
                SetStateAfterListOrFailedSearch();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TO DO: Validate the input fields
            int searchId = Convert.ToInt32(txtBoxCustomerId.Text);
            DataRow row = dtCustomers.Rows.Find(searchId);
            if (row != null)
            {
                row["Name"] = txtBoxName.Text.Trim();
                row["Street"] = txtBoxStreet.Text.Trim();
                row["StreetNumber"] = txtBoxStreetNumber.Text.Trim();
                row["City"] = txtBoxCity.Text.Trim();
                row["PostalCode"] = txtBoxPostalCode.Text.Trim();
                row["PhoneNumber"] = txtBoxPhoneNumber.Text.Trim();
                row["FaxNumber"] = txtBoxFaxNumber.Text.Trim();
                row["CreditLimit"] = Convert.ToDecimal(txtBoxCreditLimit.Text);
                row["StatusID"] = cmbBoxStatus.SelectedValue;
                MessageBox.Show("Customer updated successfully.", "Update Customer");
            }
            else
            {
                MessageBox.Show("Customer not found.", "Update Customer");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate the ID field
            int searchId = Convert.ToInt32(txtBoxCustomerId.Text);
            DataRow row = dtCustomers.Rows.Find(searchId);
            if (row != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    row.Delete();
                    MessageBox.Show("Customer deleted successfully.", "Delete Customer");
                }
            }
            else
            {
                MessageBox.Show("Customer not found.", "Delete Customer");
            }
        }
        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            adapter.Update(dsCustomersDB.Tables["Customers"]);
            MessageBox.Show("Database updated successfully.", "Update Database");
        }
        private void btnListAll_Click(object sender, EventArgs e)
        {
            dtGridCustomers.DataSource = dsCustomersDB.Tables["Customers"];
            SetStateAfterListOrFailedSearch();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtBoxCustomerId.Clear();
            txtBoxName.Clear();
            txtBoxStreet.Clear();
            txtBoxStreetNumber.Clear();
            txtBoxCity.Clear();
            txtBoxPostalCode.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxFaxNumber.Clear();
            txtBoxCreditLimit.Clear();
            cmbBoxStatus.SelectedIndex = -1;
            dtGridCustomers.DataSource = null;
            SetInitialState();
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
        private void SetInitialState()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdateDatabase.Enabled = false;
            btnClearAll.Enabled = false;
            cmbBoxStatus.SelectedIndex = -1;
            txtBoxCustomerId.ReadOnly = false;
        }
        private void SetStateAfterSuccessfulSearch()
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdateDatabase.Enabled = true;
            btnClearAll.Enabled = true;
            txtBoxCustomerId.ReadOnly = true;
        }
        private void SetStateAfterListOrFailedSearch()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdateDatabase.Enabled = false;
            btnClearAll.Enabled = true;
            txtBoxCustomerId.ReadOnly = false;
        }
        private void PopulateComboBoxStatus()
        {
            // Load the status list from the database
            StatusDB.LoadStatus();
            BindingSource bsStatus = new BindingSource();
            bsStatus.DataSource = StatusDB.dsStatus.Tables["Status"];
            cmbBoxStatus.DataSource = bsStatus;
            cmbBoxStatus.DisplayMember = "State";
            cmbBoxStatus.ValueMember = "StatusID";
        }
        private void CreateCustomerDataSet()
        {
            // Create a dataset and a table to store the customers
            dsCustomersDB = new DataSet("CustomersDS");
            dtCustomers = new DataTable("Customers");
            dsCustomersDB.Tables.Add(dtCustomers);
            dtCustomers.Columns.Add("CustomerID", typeof(int));
            dtCustomers.Columns.Add("Name", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("StreetNumber", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("PhoneNumber", typeof(string));
            dtCustomers.Columns.Add("FaxNumber", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(int));
            dtCustomers.Columns.Add("StatusID", typeof(int));
            // Set the primary key and auto increment
            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerID"] };
            dtCustomers.Columns["CustomerID"].AutoIncrement = true;
            dtCustomers.Columns["CustomerID"].AutoIncrementSeed = 1;
            dtCustomers.Columns["CustomerID"].AutoIncrementStep = 1;
            // Create a data adapter and a command builder
            adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Customers");
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            // Fill the dataset with the customers table
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Customers", UtilityDB.GetDBConnection());
            adapter.Fill(dsCustomersDB.Tables["Customers"]);            
        }
        #endregion
    }
}