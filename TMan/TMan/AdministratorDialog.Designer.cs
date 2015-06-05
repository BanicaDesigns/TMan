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
            this.tabControl1.SuspendLayout();
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
            this.tabUsersManagement.ForeColor = System.Drawing.Color.Red;
            this.tabUsersManagement.Location = new System.Drawing.Point(4, 22);
            this.tabUsersManagement.Name = "tabUsersManagement";
            this.tabUsersManagement.Size = new System.Drawing.Size(530, 456);
            this.tabUsersManagement.TabIndex = 2;
            this.tabUsersManagement.Text = "Users management";
            this.tabUsersManagement.UseWaitCursor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabUsersManagement;

    }
}