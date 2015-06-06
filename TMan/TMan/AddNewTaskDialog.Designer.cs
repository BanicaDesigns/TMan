namespace TMan
{
    partial class AddNewTaskDialog
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
            this.nudNewTaskEstinamtion = new System.Windows.Forms.NumericUpDown();
            this.tbNewTaskTitle = new System.Windows.Forms.TextBox();
            this.tbNewTaskDescription = new System.Windows.Forms.TextBox();
            this.cbNewTaskAssignedTo = new System.Windows.Forms.ComboBox();
            this.assignedTo = new System.Windows.Forms.Label();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTaskEstinamtion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estimation";
            // 
            // nudNewTaskEstinamtion
            // 
            this.nudNewTaskEstinamtion.Location = new System.Drawing.Point(83, 103);
            this.nudNewTaskEstinamtion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNewTaskEstinamtion.Name = "nudNewTaskEstinamtion";
            this.nudNewTaskEstinamtion.Size = new System.Drawing.Size(120, 20);
            this.nudNewTaskEstinamtion.TabIndex = 3;
            this.nudNewTaskEstinamtion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbNewTaskTitle
            // 
            this.tbNewTaskTitle.Location = new System.Drawing.Point(80, 25);
            this.tbNewTaskTitle.Name = "tbNewTaskTitle";
            this.tbNewTaskTitle.Size = new System.Drawing.Size(189, 20);
            this.tbNewTaskTitle.TabIndex = 4;
            // 
            // tbNewTaskDescription
            // 
            this.tbNewTaskDescription.Location = new System.Drawing.Point(80, 51);
            this.tbNewTaskDescription.Multiline = true;
            this.tbNewTaskDescription.Name = "tbNewTaskDescription";
            this.tbNewTaskDescription.Size = new System.Drawing.Size(189, 40);
            this.tbNewTaskDescription.TabIndex = 5;
            // 
            // cbNewTaskAssignedTo
            // 
            this.cbNewTaskAssignedTo.FormattingEnabled = true;
            this.cbNewTaskAssignedTo.Location = new System.Drawing.Point(82, 130);
            this.cbNewTaskAssignedTo.Name = "cbNewTaskAssignedTo";
            this.cbNewTaskAssignedTo.Size = new System.Drawing.Size(121, 21);
            this.cbNewTaskAssignedTo.TabIndex = 6;
            // 
            // assignedTo
            // 
            this.assignedTo.AutoSize = true;
            this.assignedTo.Location = new System.Drawing.Point(14, 133);
            this.assignedTo.Name = "assignedTo";
            this.assignedTo.Size = new System.Drawing.Size(62, 13);
            this.assignedTo.TabIndex = 7;
            this.assignedTo.Text = "Assigned to";
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(170, 173);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(99, 23);
            this.btnAddNewTask.TabIndex = 8;
            this.btnAddNewTask.Text = "Add";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // AddNewTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.assignedTo);
            this.Controls.Add(this.cbNewTaskAssignedTo);
            this.Controls.Add(this.tbNewTaskDescription);
            this.Controls.Add(this.tbNewTaskTitle);
            this.Controls.Add(this.nudNewTaskEstinamtion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewTaskDialog";
            this.Text = "AddNewTaskDialog";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTaskEstinamtion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNewTaskEstinamtion;
        private System.Windows.Forms.TextBox tbNewTaskTitle;
        private System.Windows.Forms.TextBox tbNewTaskDescription;
        private System.Windows.Forms.ComboBox cbNewTaskAssignedTo;
        private System.Windows.Forms.Label assignedTo;
        private System.Windows.Forms.Button btnAddNewTask;
    }
}