namespace TMan
{
    partial class AddNewUserDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewUserUserName = new System.Windows.Forms.TextBox();
            this.tbNewUserPassword = new System.Windows.Forms.TextBox();
            this.cbNewUserRole = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // tbNewUserUserName
            // 
            this.tbNewUserUserName.Location = new System.Drawing.Point(119, 29);
            this.tbNewUserUserName.Name = "tbNewUserUserName";
            this.tbNewUserUserName.Size = new System.Drawing.Size(100, 20);
            this.tbNewUserUserName.TabIndex = 3;
            // 
            // tbNewUserPassword
            // 
            this.tbNewUserPassword.Location = new System.Drawing.Point(119, 64);
            this.tbNewUserPassword.Name = "tbNewUserPassword";
            this.tbNewUserPassword.Size = new System.Drawing.Size(100, 20);
            this.tbNewUserPassword.TabIndex = 4;
            // 
            // cbNewUserRole
            // 
            this.cbNewUserRole.FormattingEnabled = true;
            this.cbNewUserRole.Items.AddRange(new object[] {
            "Administrator",
            "RegularUser"});
            this.cbNewUserRole.Location = new System.Drawing.Point(119, 98);
            this.cbNewUserRole.Name = "cbNewUserRole";
            this.cbNewUserRole.Size = new System.Drawing.Size(100, 21);
            this.cbNewUserRole.TabIndex = 5;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(90, 147);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(112, 23);
            this.btnAddNewUser.TabIndex = 6;
            this.btnAddNewUser.Text = "Create";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // AddNewUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.cbNewUserRole);
            this.Controls.Add(this.tbNewUserPassword);
            this.Controls.Add(this.tbNewUserUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUserDialog";
            this.Text = "AddNewUserDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewUserUserName;
        private System.Windows.Forms.TextBox tbNewUserPassword;
        private System.Windows.Forms.ComboBox cbNewUserRole;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}