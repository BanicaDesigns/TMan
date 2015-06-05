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
            }
        }
    }
}
