namespace Hi_TechApp
{
    partial class FormLogin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(257, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Hi-Tech Distribution";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(829, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 31);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 729);
            this.panelMenu.TabIndex = 26;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(808, 100);
            this.panelTitle.TabIndex = 27;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(177, 98);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(167, 31);
            this.btnChangePassword.TabIndex = 31;
            this.btnChangePassword.Text = "&Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(352, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 31);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 20);
            this.lblUserName.TabIndex = 26;
            this.lblUserName.Text = "Username:";
            // 
            // txtBoxUsername
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxUsername, 2);
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(177, 3);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(345, 26);
            this.txtBoxUsername.TabIndex = 28;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxPassword, 2);
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(177, 52);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(345, 26);
            this.txtBoxPassword.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChangePassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPassword, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(320, 301);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.08772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.45614F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.45614F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 142);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnExit);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}