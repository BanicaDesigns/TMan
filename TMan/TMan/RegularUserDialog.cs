﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMan.Helpers;

namespace TMan
{
    public partial class RegularUserDialog : Form
    {
        private string InitialTaskState;

        public RegularUserDialog()
        {
            InitializeComponent();
            TaskManagementTabInitialButtonsAvailability();
        }

        private void RegularUserDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userId = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]);

                ReloadTasksRelatedToMe(entities, userId);

                lbComments.Items.Clear();

                CommonHelper.PopulateComboboxWithAllUsers(cbSelectedTaskAssignedTo, entities);               
            }
        }

        private void ReloadTasksRelatedToMe(TManDBEntities entities, int userId)
        {
            var tasksRelatedToMe = (from task in entities.TMTasks
                                    where task.AssignedTo == userId || task.CreatedBy == userId
                                    select task).ToArray();

            lbAllTasksRelatedToMe.Items.Clear();

            foreach (var task in tasksRelatedToMe)
            {
                lbAllTasksRelatedToMe.Items.Add(string.Format(Properties.Resources.TASK_LABEL_LAYOUT
                                                            , task.TaskId
                                                            , task.Title
                                                            , task.Status));
            }
        }

        private void lbAllTasksRelatedToMe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItemText = ((System.Windows.Forms.ListBox)(sender)).Text;
            var taskObject = GetSelectedTaskFromDatabase(selectedItemText);

            FillUpBasicTaskInformation(taskObject);

            FillUpCommentsForTheTask(taskObject);

            TaskManagementTabButtonsAvailAfterTaskSelection();

            this.InitialTaskState = GetSerializedTaskStat(taskObject);          
        }

        private string GetSerializedTaskStat(TMTask taskObject = null)
        {
            //title_description_status_assignedto_datecreated_lastmodified_estimation
            if (taskObject != null)
            {
                return string.Format(Properties.Resources.SERIALIZED_TASK_TEMPL, taskObject.Title
                                                                                , taskObject.Description
                                                                                , taskObject.Status
                                                                                , cbSelectedTaskAssignedTo.Text
                                                                                , taskObject.DateCreated
                                                                                , taskObject.DateLastModified
                                                                                , taskObject.Estimation);
            }
            else
            {
                return string.Format(Properties.Resources.SERIALIZED_TASK_TEMPL, tbSelectedTaskTitle.Text
                                                                                , tbSelectedTaskDescription.Text
                                                                                , cbSelectedTasStatus.Text
                                                                                , cbSelectedTaskAssignedTo.Text
                                                                                , dtpSelectedTaskDateCreated.Value
                                                                                , dtpSelectedTaskLastModified.Value
                                                                                , tbSelectedTaskEstimation.Text);
            }
        }

        private void FillUpCommentsForTheTask(TMTask taskObject)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userId = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]);
                var taskId = Convert.ToInt32(tbSelectedTaskId.Text);

                var allCommentsToTask = from comment in entities.Comments
                                        join user in entities.TMUsers on comment.MadeBy equals user.UserId
                                        join task in entities.TMTasks on comment.ToTask equals task.TaskId
                                        where task.TaskId == taskId
                                        select new {user.Username, comment.Text};

                lbComments.Items.Clear();

                foreach (var item in allCommentsToTask)
                    lbComments.Items.Add(string.Format("{0}: {1}", item.Username, item.Text));
            } 
        }

        private void FillUpBasicTaskInformation(TMTask taskObject = null)
        {
            tbSelectedTaskId.Text = taskObject != null ? taskObject.TaskId.ToString() : string.Empty;
            tbSelectedTaskTitle.Text = taskObject != null ? taskObject.Title: string.Empty;
            tbSelectedTaskDescription.Text = taskObject != null ? taskObject.Description : string.Empty;
            cbSelectedTasStatus.Text = taskObject != null ? taskObject.Status : string.Empty;
            cbSelectedTaskAssignedTo.Text = taskObject != null ? GetUserAssignedForTask(taskObject.AssignedTo): string.Empty;
            tbSelectedTaskCreatedBy.Text = taskObject != null ? GetUserCreatedTheTask(taskObject.CreatedBy): string.Empty;
            dtpSelectedTaskDateCreated.Value = taskObject != null ? (DateTime)taskObject.DateCreated: DateTime.Now;
            dtpSelectedTaskLastModified.Value = taskObject != null ? (DateTime)taskObject.DateLastModified : DateTime.Now;
            tbSelectedTaskEstimation.Text = taskObject != null ? taskObject.Estimation.ToString():string.Empty;
        }

        private string GetUserCreatedTheTask(int? createdBy)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userCreatedTask = (from user in entities.TMUsers
                                       where user.UserId == createdBy
                                       select new { Username = user.Username, UserID = user.UserId }).FirstOrDefault();

                return string.Format(Properties.Resources.USER_IN_LAYOUT_TEMPL, userCreatedTask.Username, userCreatedTask.UserID);
            }
        }

        private string GetUserAssignedForTask(int? assignedTo)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userAssignedForTask = (from user in entities.TMUsers
                                           where user.UserId == assignedTo
                                           select new { Username = user.Username, UserID = user.UserId}).FirstOrDefault();

                return string.Format(Properties.Resources.USER_IN_LAYOUT_TEMPL, userAssignedForTask.Username, userAssignedForTask.UserID);
            }
        }

        private TMTask GetSelectedTaskFromDatabase(string selectedItemText)
        {
            var taskId = Convert.ToInt32(selectedItemText.Trim().Split(']')[0].Split(':')[1]);

            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var taskFromDb = (from el in entities.TMTasks
                                     where el.TaskId == taskId
                                     select el).FirstOrDefault();

                return taskFromDb;
            }
        }

        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            var newCommentText = tbNewComment.Text;

            if (newCommentText.Trim() == string.Empty)
                return;

            var newCommentMadeByUserId = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]);
            var newCommentMadeByUserName = Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[1];
            var newCommentToTask = Convert.ToInt32(tbSelectedTaskId.Text);

            lbComments.Items.Add(string.Format("{0}: {1}", newCommentMadeByUserName, newCommentText));

            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                entities.Comments.Add(new Comment() { MadeBy = newCommentMadeByUserId, ToTask = newCommentToTask, Text = newCommentText });

                tbNewComment.Clear();

                entities.SaveChanges();
            }
        }

        private void TaskManagementTabInitialButtonsAvailability()
        {
            btnAddNewComment.Enabled = false;
            btnDeleteTask.Enabled = false;
            btnEditTask.Enabled = false;
        }

        private void TaskManagementTabButtonsAvailAfterTaskSelection()
        {
            btnAddNewComment.Enabled = true;
            btnDeleteTask.Enabled = true;
            btnEditTask.Enabled = true;

            var taskIsAssignedToMe = (cbSelectedTaskAssignedTo.Text.Split(',')[1].Split(':')[1] == Environment
                                                                                                        .GetEnvironmentVariable(Properties.Resources.UserInfo)
                                                                                                        .Split('_')[0]);

            btnReportWorkOnTask.Visible = taskIsAssignedToMe? true : false;
            lblHoursSpentOnTask.Visible = taskIsAssignedToMe ? true : false;
            nudNumberOfHours.Visible = taskIsAssignedToMe ? true : false;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            //title_description_status_assignedto_datecreated_lastmodified_estimation
            var latestTaskCredentials = GetSerializedTaskStat();
            var latestTaskSplitted = latestTaskCredentials.Split('_');

            if (string.Compare(this.InitialTaskState, latestTaskCredentials) == 0)
                return;

            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var task = new TMan.TMTask()
                {
                    TaskId = Convert.ToInt32(tbSelectedTaskId.Text),
                    Title = latestTaskSplitted[0],
                    Description = latestTaskSplitted[1],
                    AssignedTo = Convert.ToInt32(cbSelectedTaskAssignedTo.Text.Split(',')[1].Split(':')[1]),
                    CreatedBy = Convert.ToInt32(tbSelectedTaskCreatedBy.Text.Split(',')[1].Split(':')[1]),
                    DateCreated = Convert.ToDateTime(latestTaskSplitted[4]),
                    DateLastModified = Convert.ToDateTime(latestTaskSplitted[5]),
                    Estimation = Convert.ToInt32(latestTaskSplitted[6]),
                    Status = latestTaskSplitted[2]
                };

                entities.TMTasks.Attach(task);
                entities.Entry(task).State = EntityState.Modified; 
                entities.SaveChanges();
            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            var newTaskDialog = new AddNewTaskDialog();
            newTaskDialog.ShowDialog();

            UpdateListBoxWithTasks();
            FillUpBasicTaskInformation();
            lbComments.Items.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                try
                {
                    TMTask taskFOrDelete = new TMTask()
                    {
                        TaskId = Convert.ToInt32(tbSelectedTaskId.Text)
                    };

                    entities.TMTasks.Attach(taskFOrDelete);
                    entities.TMTasks.Remove(taskFOrDelete);
                    entities.SaveChanges();

                    UpdateListBoxWithTasks();

                    MessageBox.Show("Deletion was successful!", "Info", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deletion failed! More info:\n"+ex.Message, "Info", MessageBoxButtons.OK);
                }               
            }           
        }

        private void UpdateListBoxWithTasks()
        {
            FillUpBasicTaskInformation();

            using (TManDBEntities entities = new TManDBEntities())
            {
                var userId = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]);
                entities.Database.Connection.Open();
                ReloadTasksRelatedToMe(entities, userId);
            }

            lbComments.Items.Clear();
        }

        private void btnReportWorkOnTask_Click(object sender, EventArgs e)
        {
            try
            {
                var toTaskId = Convert.ToInt32(tbSelectedTaskId.Text);

                var reportOnTask = new TMan.TasksReport()
                {
                    ToTask = toTaskId,
                    ByUser = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]),
                    NumberOfHours = Convert.ToInt32(nudNumberOfHours.Value),
                    DateOfReport = DateTime.Now
                };

                using (TManDBEntities entities = new TManDBEntities())
                {
                    entities.Database.Connection.Open();
                    entities.TasksReports.Add(reportOnTask);
                    entities.SaveChanges();
                }

                MessageBox.Show("The report on task was successfuly added!", "Info", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The report on task failed to get added! See more:\n"+ex.Message, "Info", MessageBoxButtons.OK);
            }
        }
    }
}
