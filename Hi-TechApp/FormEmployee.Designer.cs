namespace Hi_TechApp
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.cmbBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gBoxEmployee = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gBoxUser = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBoxDateModified = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.tblDateCreated = new System.Windows.Forms.Label();
            this.txtBoxDateCreated = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnListAllEmployees = new System.Windows.Forms.Button();
            this.btnListAllUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbBoxUserRole = new System.Windows.Forms.ComboBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gBoxEmployee.SuspendLayout();
            this.gBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(15, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(138, 65);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(430, 26);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(138, 94);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(430, 26);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(138, 123);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(430, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(138, 152);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(430, 26);
            this.txtBoxPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 155);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(117, 20);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(15, 184);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 20);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position:";
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEmployee.Location = new System.Drawing.Point(592, 31);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(167, 31);
            this.btnAddNewEmployee.TabIndex = 12;
            this.btnAddNewEmployee.Text = "&Add New";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // cmbBoxPosition
            // 
            this.cmbBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPosition.FormattingEnabled = true;
            this.cmbBoxPosition.Location = new System.Drawing.Point(138, 183);
            this.cmbBoxPosition.Name = "cmbBoxPosition";
            this.cmbBoxPosition.Size = new System.Drawing.Size(430, 28);
            this.cmbBoxPosition.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(290, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 29);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Employee and User Maintenance";
            // 
            // txtBoxEmployeeId
            // 
            this.txtBoxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmployeeId.Location = new System.Drawing.Point(138, 33);
            this.txtBoxEmployeeId.Name = "txtBoxEmployeeId";
            this.txtBoxEmployeeId.Size = new System.Drawing.Size(430, 26);
            this.txtBoxEmployeeId.TabIndex = 16;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(15, 36);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(104, 20);
            this.lblEmployeeId.TabIndex = 15;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(829, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 31);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gBoxEmployee
            // 
            this.gBoxEmployee.Controls.Add(this.btnDeleteEmployee);
            this.gBoxEmployee.Controls.Add(this.txtBoxEmployeeId);
            this.gBoxEmployee.Controls.Add(this.btnAddNewEmployee);
            this.gBoxEmployee.Controls.Add(this.lblFirstName);
            this.gBoxEmployee.Controls.Add(this.txtBoxFirstName);
            this.gBoxEmployee.Controls.Add(this.lblEmployeeId);
            this.gBoxEmployee.Controls.Add(this.lblLastName);
            this.gBoxEmployee.Controls.Add(this.txtBoxLastName);
            this.gBoxEmployee.Controls.Add(this.cmbBoxPosition);
            this.gBoxEmployee.Controls.Add(this.lblEmail);
            this.gBoxEmployee.Controls.Add(this.txtBoxEmail);
            this.gBoxEmployee.Controls.Add(this.lblPosition);
            this.gBoxEmployee.Controls.Add(this.lblPhoneNumber);
            this.gBoxEmployee.Controls.Add(this.txtBoxPhoneNumber);
            this.gBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEmployee.Location = new System.Drawing.Point(17, 56);
            this.gBoxEmployee.Name = "gBoxEmployee";
            this.gBoxEmployee.Size = new System.Drawing.Size(777, 230);
            this.gBoxEmployee.TabIndex = 18;
            this.gBoxEmployee.TabStop = false;
            this.gBoxEmployee.Text = "Employee Information";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(829, 139);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(167, 31);
            this.btnClearAll.TabIndex = 20;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(592, 63);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(167, 31);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "&Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(829, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gBoxUser
            // 
            this.gBoxUser.Controls.Add(this.cmbBoxUserRole);
            this.gBoxUser.Controls.Add(this.btnDeleteUser);
            this.gBoxUser.Controls.Add(this.txtBoxUserId);
            this.gBoxUser.Controls.Add(this.btnAddNewUser);
            this.gBoxUser.Controls.Add(this.lblUserName);
            this.gBoxUser.Controls.Add(this.txtBoxUsername);
            this.gBoxUser.Controls.Add(this.lblUserId);
            this.gBoxUser.Controls.Add(this.lblPassword);
            this.gBoxUser.Controls.Add(this.txtBoxPassword);
            this.gBoxUser.Controls.Add(this.txtBoxDateModified);
            this.gBoxUser.Controls.Add(this.lblUserRole);
            this.gBoxUser.Controls.Add(this.lblDateModified);
            this.gBoxUser.Controls.Add(this.tblDateCreated);
            this.gBoxUser.Controls.Add(this.txtBoxDateCreated);
            this.gBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUser.Location = new System.Drawing.Point(17, 292);
            this.gBoxUser.Name = "gBoxUser";
            this.gBoxUser.Size = new System.Drawing.Size(777, 230);
            this.gBoxUser.TabIndex = 20;
            this.gBoxUser.TabStop = false;
            this.gBoxUser.Text = "User Information";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(592, 63);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(167, 31);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "&Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserId.Location = new System.Drawing.Point(138, 33);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(430, 26);
            this.txtBoxUserId.TabIndex = 16;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(592, 31);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(167, 31);
            this.btnAddNewUser.TabIndex = 12;
            this.btnAddNewUser.Text = "&Add New";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(15, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username:";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(138, 65);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(430, 26);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(15, 36);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(68, 20);
            this.lblUserId.TabIndex = 15;
            this.lblUserId.Text = "User ID:";
            // 
            // txtBoxDateModified
            // 
            this.txtBoxDateModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDateModified.FormattingEnabled = true;
            this.txtBoxDateModified.Location = new System.Drawing.Point(138, 183);
            this.txtBoxDateModified.Name = "txtBoxDateModified";
            this.txtBoxDateModified.Size = new System.Drawing.Size(430, 28);
            this.txtBoxDateModified.TabIndex = 13;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(15, 126);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(84, 20);
            this.lblUserRole.TabIndex = 4;
            this.lblUserRole.Text = "User Role:";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateModified.Location = new System.Drawing.Point(15, 184);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(112, 20);
            this.lblDateModified.TabIndex = 8;
            this.lblDateModified.Text = "Date modified:";
            // 
            // tblDateCreated
            // 
            this.tblDateCreated.AutoSize = true;
            this.tblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDateCreated.Location = new System.Drawing.Point(15, 155);
            this.tblDateCreated.Name = "tblDateCreated";
            this.tblDateCreated.Size = new System.Drawing.Size(106, 20);
            this.tblDateCreated.TabIndex = 6;
            this.tblDateCreated.Text = "Date created:";
            // 
            // txtBoxDateCreated
            // 
            this.txtBoxDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDateCreated.Location = new System.Drawing.Point(138, 152);
            this.txtBoxDateCreated.Name = "txtBoxDateCreated";
            this.txtBoxDateCreated.Size = new System.Drawing.Size(430, 26);
            this.txtBoxDateCreated.TabIndex = 7;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(17, 538);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(777, 179);
            this.dataGridViewEmployees.TabIndex = 21;
            // 
            // btnListAllEmployees
            // 
            this.btnListAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllEmployees.Location = new System.Drawing.Point(829, 538);
            this.btnListAllEmployees.Name = "btnListAllEmployees";
            this.btnListAllEmployees.Size = new System.Drawing.Size(167, 31);
            this.btnListAllEmployees.TabIndex = 21;
            this.btnListAllEmployees.Text = "List all employees";
            this.btnListAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnListAllUsers
            // 
            this.btnListAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllUsers.Location = new System.Drawing.Point(829, 575);
            this.btnListAllUsers.Name = "btnListAllUsers";
            this.btnListAllUsers.Size = new System.Drawing.Size(167, 31);
            this.btnListAllUsers.TabIndex = 22;
            this.btnListAllUsers.Text = "List all users";
            this.btnListAllUsers.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(829, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbBoxUserRole
            // 
            this.cmbBoxUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUserRole.FormattingEnabled = true;
            this.cmbBoxUserRole.Location = new System.Drawing.Point(138, 123);
            this.cmbBoxUserRole.Name = "cmbBoxUserRole";
            this.cmbBoxUserRole.Size = new System.Drawing.Size(430, 28);
            this.cmbBoxUserRole.TabIndex = 21;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(138, 94);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(430, 26);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnListAllUsers);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnListAllEmployees);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gBoxUser);
            this.Controls.Add(this.gBoxEmployee);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.gBoxEmployee.ResumeLayout(false);
            this.gBoxEmployee.PerformLayout();
            this.gBoxUser.ResumeLayout(false);
            this.gBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.ComboBox cmbBoxPosition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gBoxEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gBoxUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox txtBoxDateModified;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label tblDateCreated;
        private System.Windows.Forms.TextBox txtBoxDateCreated;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button btnListAllEmployees;
        private System.Windows.Forms.Button btnListAllUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbBoxUserRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}