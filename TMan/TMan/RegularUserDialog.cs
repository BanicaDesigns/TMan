using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMan
{
    public partial class RegularUserDialog : Form
    {
        public RegularUserDialog()
        {
            InitializeComponent();
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

                var allAvailableUsers = from user in entities.TMUsers
                                        select user;

                foreach (var user in allAvailableUsers)
                    cbSelectedTaskAssignedTo.Items.Add(user.Username);
                
            }
        }

        private void lbAllTasksRelatedToMe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItemText = ((System.Windows.Forms.ListBox)(sender)).Text;
            var taskObject = GetSelectedTaskFromDatabase(selectedItemText);

            FillUpBasicTaskInformation(taskObject);

            FillUpCommentsForTheTask(taskObject);
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
                                        where user.UserId == userId && task.TaskId == taskId
                                        select new {user.Username, comment.Text};

                lbComments.Items.Clear();

                foreach (var item in allCommentsToTask)
                    lbComments.Items.Add(string.Format("{0}: {1}", item.Username, item.Text));
            } 
        }

        private void FillUpBasicTaskInformation(TMTask taskObject)
        {
            tbSelectedTaskId.Text = taskObject.TaskId.ToString();
            tbSelectedTaskTitle.Text = taskObject.Title;
            tbSelectedTaskDescription.Text = taskObject.Description;
            cbSelectedTasStatus.Text = taskObject.Status;
            cbSelectedTaskAssignedTo.Text = GetUserAssignedForTask(taskObject.AssignedTo);
            tbSelectedTaskCreatedBy.Text = GetUserCreatedTheTask(taskObject.CreatedBy);
            dtpSelectedTaskDateCreated.Value =(DateTime)taskObject.DateCreated;
            dtpSelectedTaskLastModified.Value = (DateTime)taskObject.DateLastModified;
            tbSelectedTaskEstimation.Text = taskObject.Estimation.ToString();
        }

        private string GetUserCreatedTheTask(int? createdBy)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userCreatedTask = (from user in entities.TMUsers
                                       where user.UserId == createdBy
                                       select user.Username).FirstOrDefault();

                return userCreatedTask;
            }
        }

        private string GetUserAssignedForTask(int? assignedTo)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                entities.Database.Connection.Open();

                var userAssignedForTask = (from user in entities.TMUsers
                                           where user.UserId == assignedTo
                                           select user.Username).FirstOrDefault();
                
                return userAssignedForTask;
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
    }
}
