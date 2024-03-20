namespace Hi_TechApp
{
    partial class FormUserAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtBoxPosition = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbBoxUserRole = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteUserAccount = new System.Windows.Forms.Button();
            this.btnAddNewUserAccount = new System.Windows.Forms.Button();
            this.dtGridUserAccounts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnListAllUsers = new System.Windows.Forms.Button();
            this.btnLinkEmployee = new System.Windows.Forms.Button();
            this.tbLayoutButtons1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUserAccounts)).BeginInit();
            this.panel3.SuspendLayout();
            this.tbLayoutButtons1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "User Account Maintenance";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtGridUserAccounts);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 629);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnLinkEmployee, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEmployeeId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUserId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUserId, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPosition, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPosition, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUsername, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserRole, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxUserRole, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 305);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(104, 20);
            this.lblEmployeeId.TabIndex = 33;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // txtBoxFirstName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxFirstName, 2);
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(132, 53);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(252, 26);
            this.txtBoxFirstName.TabIndex = 19;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 20);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First name:";
            // 
            // txtBoxEmployeeId
            // 
            this.txtBoxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmployeeId.Location = new System.Drawing.Point(132, 3);
            this.txtBoxEmployeeId.Name = "txtBoxEmployeeId";
            this.txtBoxEmployeeId.Size = new System.Drawing.Size(123, 26);
            this.txtBoxEmployeeId.TabIndex = 18;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(390, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(68, 20);
            this.lblUserId.TabIndex = 32;
            this.lblUserId.Text = "User ID:";
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserId.Location = new System.Drawing.Point(519, 3);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(123, 26);
            this.txtBoxUserId.TabIndex = 28;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last name:";
            // 
            // txtBoxLastName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxLastName, 2);
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(132, 103);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(252, 26);
            this.txtBoxLastName.TabIndex = 21;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(3, 150);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 20);
            this.lblPosition.TabIndex = 30;
            this.lblPosition.Text = "Position:";
            // 
            // txtBoxPosition
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxPosition, 2);
            this.txtBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPosition.Location = new System.Drawing.Point(132, 153);
            this.txtBoxPosition.Name = "txtBoxPosition";
            this.txtBoxPosition.Size = new System.Drawing.Size(252, 26);
            this.txtBoxPosition.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxEmail, 2);
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(132, 203);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(252, 26);
            this.txtBoxEmail.TabIndex = 24;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(390, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 20);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Username:";
            // 
            // txtBoxUsername
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxUsername, 2);
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(519, 53);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(252, 26);
            this.txtBoxUsername.TabIndex = 29;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(390, 100);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(84, 20);
            this.lblUserRole.TabIndex = 22;
            this.lblUserRole.Text = "User Role:";
            // 
            // cmbBoxUserRole
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbBoxUserRole, 2);
            this.cmbBoxUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUserRole.FormattingEnabled = true;
            this.cmbBoxUserRole.Location = new System.Drawing.Point(519, 103);
            this.cmbBoxUserRole.Name = "cmbBoxUserRole";
            this.cmbBoxUserRole.Size = new System.Drawing.Size(253, 28);
            this.cmbBoxUserRole.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbLayoutButtons1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(808, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 336);
            this.panel2.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(6, 206);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(188, 34);
            this.btnClearAll.TabIndex = 35;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 35);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(6, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 35);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteUserAccount
            // 
            this.btnDeleteUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUserAccount.Location = new System.Drawing.Point(6, 129);
            this.btnDeleteUserAccount.Name = "btnDeleteUserAccount";
            this.btnDeleteUserAccount.Size = new System.Drawing.Size(188, 35);
            this.btnDeleteUserAccount.TabIndex = 32;
            this.btnDeleteUserAccount.Text = "&Delete";
            this.btnDeleteUserAccount.UseVisualStyleBackColor = true;
            this.btnDeleteUserAccount.Click += new System.EventHandler(this.btnDeleteUserAccount_Click);
            // 
            // btnAddNewUserAccount
            // 
            this.btnAddNewUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUserAccount.Location = new System.Drawing.Point(6, 6);
            this.btnAddNewUserAccount.Name = "btnAddNewUserAccount";
            this.btnAddNewUserAccount.Size = new System.Drawing.Size(188, 35);
            this.btnAddNewUserAccount.TabIndex = 31;
            this.btnAddNewUserAccount.Text = "&Add New";
            this.btnAddNewUserAccount.UseVisualStyleBackColor = true;
            this.btnAddNewUserAccount.Click += new System.EventHandler(this.btnAddNewUserAccount_Click);
            // 
            // dtGridUserAccounts
            // 
            this.dtGridUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUserAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridUserAccounts.Location = new System.Drawing.Point(0, 0);
            this.dtGridUserAccounts.Name = "dtGridUserAccounts";
            this.dtGridUserAccounts.Size = new System.Drawing.Size(808, 289);
            this.dtGridUserAccounts.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(808, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 289);
            this.panel3.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 37);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnListAllUsers
            // 
            this.btnListAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllUsers.Location = new System.Drawing.Point(6, 6);
            this.btnListAllUsers.Name = "btnListAllUsers";
            this.btnListAllUsers.Size = new System.Drawing.Size(188, 34);
            this.btnListAllUsers.TabIndex = 31;
            this.btnListAllUsers.Text = "List all users";
            this.btnListAllUsers.UseVisualStyleBackColor = true;
            this.btnListAllUsers.Click += new System.EventHandler(this.btnListAllUsers_Click);
            // 
            // btnLinkEmployee
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnLinkEmployee, 2);
            this.btnLinkEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmployee.Location = new System.Drawing.Point(519, 253);
            this.btnLinkEmployee.Name = "btnLinkEmployee";
            this.btnLinkEmployee.Size = new System.Drawing.Size(252, 49);
            this.btnLinkEmployee.TabIndex = 34;
            this.btnLinkEmployee.Text = "Update employee information";
            this.btnLinkEmployee.UseVisualStyleBackColor = true;
            this.btnLinkEmployee.Click += new System.EventHandler(this.btnLinkEmployee_Click);
            // 
            // tbLayoutButtons1
            // 
            this.tbLayoutButtons1.ColumnCount = 1;
            this.tbLayoutButtons1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutButtons1.Controls.Add(this.btnUpdate, 0, 2);
            this.tbLayoutButtons1.Controls.Add(this.btnSearch, 0, 1);
            this.tbLayoutButtons1.Controls.Add(this.btnDeleteUserAccount, 0, 3);
            this.tbLayoutButtons1.Controls.Add(this.btnAddNewUserAccount, 0, 0);
            this.tbLayoutButtons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutButtons1.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutButtons1.Margin = new System.Windows.Forms.Padding(5);
            this.tbLayoutButtons1.Name = "tbLayoutButtons1";
            this.tbLayoutButtons1.Padding = new System.Windows.Forms.Padding(3);
            this.tbLayoutButtons1.RowCount = 8;
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbLayoutButtons1.Size = new System.Drawing.Size(200, 336);
            this.tbLayoutButtons1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnListAllUsers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClearAll, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 289);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FormUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUserAccounts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tbLayoutButtons1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbBoxUserRole;
        private System.Windows.Forms.TextBox txtBoxEmployeeId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.DataGridView dtGridUserAccounts;
        private System.Windows.Forms.Button btnListAllUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteUserAccount;
        private System.Windows.Forms.Button btnAddNewUserAccount;
        private System.Windows.Forms.TextBox txtBoxPosition;
        private System.Windows.Forms.Button btnLinkEmployee;
        private System.Windows.Forms.TableLayoutPanel tbLayoutButtons1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}