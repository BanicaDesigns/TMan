namespace TMan
{
    partial class RegularUserDialog
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
            this.tabTaskManagement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllTasksRelatedToMe = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSelectedTaskId = new System.Windows.Forms.TextBox();
            this.tbSelectedTaskTitle = new System.Windows.Forms.TextBox();
            this.tbSelectedTaskDescription = new System.Windows.Forms.TextBox();
            this.cbSelectedTasStatus = new System.Windows.Forms.ComboBox();
            this.cbSelectedTaskAssignedTo = new System.Windows.Forms.ComboBox();
            this.tbSelectedTaskCreatedBy = new System.Windows.Forms.TextBox();
            this.dtpSelectedTaskDateCreated = new System.Windows.Forms.DateTimePicker();
            this.dtpSelectedTaskLastModified = new System.Windows.Forms.DateTimePicker();
            this.tbSelectedTaskEstimation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbComments = new System.Windows.Forms.ListBox();
            this.tbNewComment = new System.Windows.Forms.TextBox();
            this.btnAddNewComment = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnReportWorkOnTask = new System.Windows.Forms.Button();
            this.lblHoursSpentOnTask = new System.Windows.Forms.Label();
            this.nudNumberOfHours = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTaskManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHours)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTaskManagement
            // 
            this.tabTaskManagement.Controls.Add(this.nudNumberOfHours);
            this.tabTaskManagement.Controls.Add(this.lblHoursSpentOnTask);
            this.tabTaskManagement.Controls.Add(this.btnReportWorkOnTask);
            this.tabTaskManagement.Controls.Add(this.btnAddNewTask);
            this.tabTaskManagement.Controls.Add(this.btnDeleteTask);
            this.tabTaskManagement.Controls.Add(this.btnEditTask);
            this.tabTaskManagement.Controls.Add(this.btnAddNewComment);
            this.tabTaskManagement.Controls.Add(this.tbNewComment);
            this.tabTaskManagement.Controls.Add(this.tbSelectedTaskEstimation);
            this.tabTaskManagement.Controls.Add(this.tbSelectedTaskCreatedBy);
            this.tabTaskManagement.Controls.Add(this.tbSelectedTaskDescription);
            this.tabTaskManagement.Controls.Add(this.tbSelectedTaskTitle);
            this.tabTaskManagement.Controls.Add(this.tbSelectedTaskId);
            this.tabTaskManagement.Controls.Add(this.panel1);
            this.tabTaskManagement.Controls.Add(this.label11);
            this.tabTaskManagement.Controls.Add(this.dtpSelectedTaskLastModified);
            this.tabTaskManagement.Controls.Add(this.dtpSelectedTaskDateCreated);
            this.tabTaskManagement.Controls.Add(this.cbSelectedTaskAssignedTo);
            this.tabTaskManagement.Controls.Add(this.cbSelectedTasStatus);
            this.tabTaskManagement.Controls.Add(this.label10);
            this.tabTaskManagement.Controls.Add(this.label9);
            this.tabTaskManagement.Controls.Add(this.label8);
            this.tabTaskManagement.Controls.Add(this.label7);
            this.tabTaskManagement.Controls.Add(this.label6);
            this.tabTaskManagement.Controls.Add(this.label5);
            this.tabTaskManagement.Controls.Add(this.label4);
            this.tabTaskManagement.Controls.Add(this.label3);
            this.tabTaskManagement.Controls.Add(this.label2);
            this.tabTaskManagement.Controls.Add(this.lbAllTasksRelatedToMe);
            this.tabTaskManagement.Controls.Add(this.label1);
            this.tabTaskManagement.Location = new System.Drawing.Point(4, 22);
            this.tabTaskManagement.Name = "tabTaskManagement";
            this.tabTaskManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaskManagement.Size = new System.Drawing.Size(530, 456);
            this.tabTaskManagement.TabIndex = 0;
            this.tabTaskManagement.Text = "Task management";
            this.tabTaskManagement.UseVisualStyleBackColor = true;
            this.tabTaskManagement.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabTaskManagement.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks related to me:";
            // 
            // lbAllTasksRelatedToMe
            // 
            this.lbAllTasksRelatedToMe.FormattingEnabled = true;
            this.lbAllTasksRelatedToMe.Location = new System.Drawing.Point(7, 30);
            this.lbAllTasksRelatedToMe.Name = "lbAllTasksRelatedToMe";
            this.lbAllTasksRelatedToMe.Size = new System.Drawing.Size(252, 212);
            this.lbAllTasksRelatedToMe.TabIndex = 1;
            this.lbAllTasksRelatedToMe.SelectedIndexChanged += new System.EventHandler(this.lbAllTasksRelatedToMe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Assigned to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Created by:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(273, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date created:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(273, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date last modified:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(273, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Estimation:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(273, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Status:";
            // 
            // tbSelectedTaskId
            // 
            this.tbSelectedTaskId.Location = new System.Drawing.Point(303, 14);
            this.tbSelectedTaskId.Name = "tbSelectedTaskId";
            this.tbSelectedTaskId.ReadOnly = true;
            this.tbSelectedTaskId.Size = new System.Drawing.Size(216, 20);
            this.tbSelectedTaskId.TabIndex = 11;
            // 
            // tbSelectedTaskTitle
            // 
            this.tbSelectedTaskTitle.Location = new System.Drawing.Point(316, 39);
            this.tbSelectedTaskTitle.Name = "tbSelectedTaskTitle";
            this.tbSelectedTaskTitle.Size = new System.Drawing.Size(203, 20);
            this.tbSelectedTaskTitle.TabIndex = 12;
            // 
            // tbSelectedTaskDescription
            // 
            this.tbSelectedTaskDescription.Location = new System.Drawing.Point(355, 65);
            this.tbSelectedTaskDescription.Name = "tbSelectedTaskDescription";
            this.tbSelectedTaskDescription.Size = new System.Drawing.Size(164, 20);
            this.tbSelectedTaskDescription.TabIndex = 13;
            // 
            // cbSelectedTasStatus
            // 
            this.cbSelectedTasStatus.FormattingEnabled = true;
            this.cbSelectedTasStatus.Items.AddRange(new object[] {
            "New",
            "In Progress",
            "Done"});
            this.cbSelectedTasStatus.Location = new System.Drawing.Point(326, 91);
            this.cbSelectedTasStatus.Name = "cbSelectedTasStatus";
            this.cbSelectedTasStatus.Size = new System.Drawing.Size(193, 21);
            this.cbSelectedTasStatus.TabIndex = 14;
            // 
            // cbSelectedTaskAssignedTo
            // 
            this.cbSelectedTaskAssignedTo.FormattingEnabled = true;
            this.cbSelectedTaskAssignedTo.Location = new System.Drawing.Point(357, 116);
            this.cbSelectedTaskAssignedTo.Name = "cbSelectedTaskAssignedTo";
            this.cbSelectedTaskAssignedTo.Size = new System.Drawing.Size(162, 21);
            this.cbSelectedTaskAssignedTo.TabIndex = 15;
            // 
            // tbSelectedTaskCreatedBy
            // 
            this.tbSelectedTaskCreatedBy.Location = new System.Drawing.Point(357, 144);
            this.tbSelectedTaskCreatedBy.Name = "tbSelectedTaskCreatedBy";
            this.tbSelectedTaskCreatedBy.ReadOnly = true;
            this.tbSelectedTaskCreatedBy.Size = new System.Drawing.Size(162, 20);
            this.tbSelectedTaskCreatedBy.TabIndex = 16;
            // 
            // dtpSelectedTaskDateCreated
            // 
            this.dtpSelectedTaskDateCreated.Location = new System.Drawing.Point(365, 170);
            this.dtpSelectedTaskDateCreated.Name = "dtpSelectedTaskDateCreated";
            this.dtpSelectedTaskDateCreated.Size = new System.Drawing.Size(154, 20);
            this.dtpSelectedTaskDateCreated.TabIndex = 17;
            // 
            // dtpSelectedTaskLastModified
            // 
            this.dtpSelectedTaskLastModified.Location = new System.Drawing.Point(393, 196);
            this.dtpSelectedTaskLastModified.Name = "dtpSelectedTaskLastModified";
            this.dtpSelectedTaskLastModified.Size = new System.Drawing.Size(126, 20);
            this.dtpSelectedTaskLastModified.TabIndex = 18;
            // 
            // tbSelectedTaskEstimation
            // 
            this.tbSelectedTaskEstimation.Location = new System.Drawing.Point(357, 222);
            this.tbSelectedTaskEstimation.Name = "tbSelectedTaskEstimation";
            this.tbSelectedTaskEstimation.Size = new System.Drawing.Size(162, 20);
            this.tbSelectedTaskEstimation.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Comments to the task:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbComments);
            this.panel1.Location = new System.Drawing.Point(10, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 112);
            this.panel1.TabIndex = 21;
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(4, 4);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(237, 95);
            this.lbComments.TabIndex = 0;
            // 
            // tbNewComment
            // 
            this.tbNewComment.Location = new System.Drawing.Point(264, 310);
            this.tbNewComment.Multiline = true;
            this.tbNewComment.Name = "tbNewComment";
            this.tbNewComment.Size = new System.Drawing.Size(167, 52);
            this.tbNewComment.TabIndex = 22;
            // 
            // btnAddNewComment
            // 
            this.btnAddNewComment.Location = new System.Drawing.Point(444, 308);
            this.btnAddNewComment.Name = "btnAddNewComment";
            this.btnAddNewComment.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewComment.TabIndex = 23;
            this.btnAddNewComment.Text = "Comment";
            this.btnAddNewComment.UseVisualStyleBackColor = false;
            this.btnAddNewComment.Click += new System.EventHandler(this.btnAddNewComment_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditTask.Location = new System.Drawing.Point(321, 422);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(117, 23);
            this.btnEditTask.TabIndex = 24;
            this.btnEditTask.Text = "Save Changes";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(10, 422);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 25;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewTask.Location = new System.Drawing.Point(444, 422);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTask.TabIndex = 26;
            this.btnAddNewTask.Text = "New task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnReportWorkOnTask
            // 
            this.btnReportWorkOnTask.BackColor = System.Drawing.Color.Plum;
            this.btnReportWorkOnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportWorkOnTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportWorkOnTask.Location = new System.Drawing.Point(7, 248);
            this.btnReportWorkOnTask.Name = "btnReportWorkOnTask";
            this.btnReportWorkOnTask.Size = new System.Drawing.Size(133, 23);
            this.btnReportWorkOnTask.TabIndex = 27;
            this.btnReportWorkOnTask.Text = "Report work on task";
            this.btnReportWorkOnTask.UseVisualStyleBackColor = false;
            this.btnReportWorkOnTask.Visible = false;
            this.btnReportWorkOnTask.Click += new System.EventHandler(this.btnReportWorkOnTask_Click);
            // 
            // lblHoursSpentOnTask
            // 
            this.lblHoursSpentOnTask.AutoSize = true;
            this.lblHoursSpentOnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHoursSpentOnTask.Location = new System.Drawing.Point(146, 253);
            this.lblHoursSpentOnTask.Name = "lblHoursSpentOnTask";
            this.lblHoursSpentOnTask.Size = new System.Drawing.Size(42, 13);
            this.lblHoursSpentOnTask.TabIndex = 28;
            this.lblHoursSpentOnTask.Text = "hours:";
            this.lblHoursSpentOnTask.Visible = false;
            // 
            // nudNumberOfHours
            // 
            this.nudNumberOfHours.Location = new System.Drawing.Point(194, 251);
            this.nudNumberOfHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfHours.Name = "nudNumberOfHours";
            this.nudNumberOfHours.Size = new System.Drawing.Size(64, 20);
            this.nudNumberOfHours.TabIndex = 29;
            this.nudNumberOfHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfHours.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTaskManagement);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // RegularUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "RegularUserDialog";
            this.Text = "TMan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegularUserDialog_FormClosed);
            this.tabTaskManagement.ResumeLayout(false);
            this.tabTaskManagement.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHours)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage tabTaskManagement;
        private System.Windows.Forms.NumericUpDown nudNumberOfHours;
        private System.Windows.Forms.Label lblHoursSpentOnTask;
        private System.Windows.Forms.Button btnReportWorkOnTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddNewComment;
        private System.Windows.Forms.TextBox tbNewComment;
        private System.Windows.Forms.TextBox tbSelectedTaskEstimation;
        private System.Windows.Forms.TextBox tbSelectedTaskCreatedBy;
        private System.Windows.Forms.TextBox tbSelectedTaskDescription;
        private System.Windows.Forms.TextBox tbSelectedTaskTitle;
        private System.Windows.Forms.TextBox tbSelectedTaskId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbComments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpSelectedTaskLastModified;
        private System.Windows.Forms.DateTimePicker dtpSelectedTaskDateCreated;
        private System.Windows.Forms.ComboBox cbSelectedTaskAssignedTo;
        private System.Windows.Forms.ComboBox cbSelectedTasStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAllTasksRelatedToMe;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TabControl tabControl1;

    }
}