namespace TMan
{
    partial class AdministratorDialog
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
            this.tabUsersManagement = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cbAllUsers = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnSaveUserChanges = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUsersManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsersManagement);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Controls.SetChildIndex(this.tabUsersManagement, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabTaskManagement, 0);
            // 
            // tabUsersManagement
            // 
            this.tabUsersManagement.BackColor = System.Drawing.Color.Honeydew;
            this.tabUsersManagement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabUsersManagement.Controls.Add(this.btnDeleteUser);
            this.tabUsersManagement.Controls.Add(this.cbAllUsers);
            this.tabUsersManagement.Controls.Add(this.btnAddNewUser);
            this.tabUsersManagement.Controls.Add(this.btnSaveUserChanges);
            this.tabUsersManagement.Controls.Add(this.tbId);
            this.tabUsersManagement.Controls.Add(this.cbRole);
            this.tabUsersManagement.Controls.Add(this.tbPassword);
            this.tabUsersManagement.Controls.Add(this.tbUserName);
            this.tabUsersManagement.Controls.Add(this.label16);
            this.tabUsersManagement.Controls.Add(this.label15);
            this.tabUsersManagement.Controls.Add(this.label14);
            this.tabUsersManagement.Controls.Add(this.label13);
            this.tabUsersManagement.Controls.Add(this.label12);
            this.tabUsersManagement.ForeColor = System.Drawing.Color.Red;
            this.tabUsersManagement.Location = new System.Drawing.Point(4, 22);
            this.tabUsersManagement.Name = "tabUsersManagement";
            this.tabUsersManagement.Size = new System.Drawing.Size(530, 456);
            this.tabUsersManagement.TabIndex = 2;
            this.tabUsersManagement.Text = "Users management";
            this.tabUsersManagement.UseWaitCursor = true;
            this.tabUsersManagement.Click += new System.EventHandler(this.tabUsersManagement_Click);
            this.tabUsersManagement.Enter += new System.EventHandler(this.tabUsersManagement_Enter);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteUser.Location = new System.Drawing.Point(398, 40);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.UseWaitCursor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cbAllUsers
            // 
            this.cbAllUsers.FormattingEnabled = true;
            this.cbAllUsers.Location = new System.Drawing.Point(109, 42);
            this.cbAllUsers.Name = "cbAllUsers";
            this.cbAllUsers.Size = new System.Drawing.Size(121, 21);
            this.cbAllUsers.TabIndex = 12;
            this.cbAllUsers.UseWaitCursor = true;
            this.cbAllUsers.SelectedIndexChanged += new System.EventHandler(this.cbAllUsers_SelectedIndexChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Location = new System.Drawing.Point(398, 417);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(111, 23);
            this.btnAddNewUser.TabIndex = 11;
            this.btnAddNewUser.Text = "Add new";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.UseWaitCursor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnSaveUserChanges
            // 
            this.btnSaveUserChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUserChanges.Location = new System.Drawing.Point(220, 262);
            this.btnSaveUserChanges.Name = "btnSaveUserChanges";
            this.btnSaveUserChanges.Size = new System.Drawing.Size(111, 23);
            this.btnSaveUserChanges.TabIndex = 10;
            this.btnSaveUserChanges.Text = "Save changes";
            this.btnSaveUserChanges.UseVisualStyleBackColor = true;
            this.btnSaveUserChanges.UseWaitCursor = true;
            this.btnSaveUserChanges.Click += new System.EventHandler(this.btnSaveUserChanges_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(231, 210);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 9;
            this.tbId.UseWaitCursor = true;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Administrator",
            "RegularUser"});
            this.cbRole.Location = new System.Drawing.Point(231, 183);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(100, 21);
            this.cbRole.TabIndex = 8;
            this.cbRole.UseWaitCursor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(231, 153);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseWaitCursor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(231, 126);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 6;
            this.tbUserName.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(200, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Id:";
            this.label16.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(185, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Role:";
            this.label15.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(157, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Password:";
            this.label14.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(157, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Username:";
            this.label13.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(28, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select user:";
            this.label12.UseWaitCursor = true;
            // 
            // AdministratorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 506);
            this.Name = "AdministratorDialog";
            this.Text = "AdministratorDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDialog_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabUsersManagement.ResumeLayout(false);
            this.tabUsersManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabUsersManagement;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnSaveUserChanges;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbAllUsers;
        private System.Windows.Forms.Button btnDeleteUser;

    }
}