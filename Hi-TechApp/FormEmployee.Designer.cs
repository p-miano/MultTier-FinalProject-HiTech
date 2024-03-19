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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLinkUserAccount = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.dtGridEmployees = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListAllEmployees = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmployees)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 100);
            this.panel1.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Employee Maintenance";
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
            this.splitContainer1.Panel2.Controls.Add(this.dtGridEmployees);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 629);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEmployeeId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxLastName, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxPosition, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPosition, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPhoneNumber, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 327);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(104, 20);
            this.lblEmployeeId.TabIndex = 15;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // txtBoxEmployeeId
            // 
            this.txtBoxEmployeeId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmployeeId.Location = new System.Drawing.Point(134, 3);
            this.txtBoxEmployeeId.Name = "txtBoxEmployeeId";
            this.txtBoxEmployeeId.Size = new System.Drawing.Size(125, 26);
            this.txtBoxEmployeeId.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(396, 130);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(117, 20);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // txtBoxEmail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxEmail, 2);
            this.txtBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(134, 133);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(256, 26);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxLastName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxLastName, 2);
            this.txtBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(527, 68);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(258, 26);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(396, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // txtBoxFirstName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxFirstName, 2);
            this.txtBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(134, 68);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(256, 26);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 65);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name:";
            // 
            // cmbBoxPosition
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbBoxPosition, 2);
            this.cmbBoxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPosition.FormattingEnabled = true;
            this.cmbBoxPosition.Location = new System.Drawing.Point(527, 3);
            this.cmbBoxPosition.Name = "cmbBoxPosition";
            this.cmbBoxPosition.Size = new System.Drawing.Size(258, 28);
            this.cmbBoxPosition.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(396, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 20);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position:";
            // 
            // txtBoxPhoneNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxPhoneNumber, 2);
            this.txtBoxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(527, 133);
            this.txtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(258, 26);
            this.txtBoxPhoneNumber.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLinkUserAccount);
            this.panel2.Controls.Add(this.btnClearAll);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDeleteEmployee);
            this.panel2.Controls.Add(this.btnAddNewEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(808, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 336);
            this.panel2.TabIndex = 0;
            // 
            // btnLinkUserAccount
            // 
            this.btnLinkUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkUserAccount.Location = new System.Drawing.Point(17, 208);
            this.btnLinkUserAccount.Name = "btnLinkUserAccount";
            this.btnLinkUserAccount.Size = new System.Drawing.Size(167, 63);
            this.btnLinkUserAccount.TabIndex = 31;
            this.btnLinkUserAccount.Text = "Create or view user account";
            this.btnLinkUserAccount.UseVisualStyleBackColor = true;
            this.btnLinkUserAccount.Click += new System.EventHandler(this.btnLinkUserAccount_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(12, 302);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(167, 31);
            this.btnClearAll.TabIndex = 30;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(17, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 31);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(21, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 31);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(17, 120);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(167, 31);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "&Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEmployee.Location = new System.Drawing.Point(17, 7);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(167, 31);
            this.btnAddNewEmployee.TabIndex = 12;
            this.btnAddNewEmployee.Text = "&Add New";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // dtGridEmployees
            // 
            this.dtGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridEmployees.Location = new System.Drawing.Point(0, 0);
            this.dtGridEmployees.Name = "dtGridEmployees";
            this.dtGridEmployees.Size = new System.Drawing.Size(808, 289);
            this.dtGridEmployees.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnListAllEmployees);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(808, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 289);
            this.panel3.TabIndex = 0;
            // 
            // btnListAllEmployees
            // 
            this.btnListAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllEmployees.Location = new System.Drawing.Point(12, 19);
            this.btnListAllEmployees.Name = "btnListAllEmployees";
            this.btnListAllEmployees.Size = new System.Drawing.Size(167, 31);
            this.btnListAllEmployees.TabIndex = 33;
            this.btnListAllEmployees.Text = "List all employees";
            this.btnListAllEmployees.UseVisualStyleBackColor = true;
            this.btnListAllEmployees.Click += new System.EventHandler(this.btnListAllEmployees_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 31);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmployees)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridEmployees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox txtBoxEmployeeId;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.ComboBox cmbBoxPosition;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnListAllEmployees;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.MaskedTextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Button btnLinkUserAccount;
    }
}