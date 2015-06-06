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
    public partial class AddNewTaskDialog : Form
    {
        public AddNewTaskDialog()
        {
            InitializeComponent();
            //Тук трябва да се добавят всички възможни user-и.
            using (TManDBEntities entities = new TManDBEntities())
            {
                TMan.Helpers.CommonHelper.PopulateComboboxWithAllUsers(cbNewTaskAssignedTo, entities); 
            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            try
            {
                var newTask = new TMTask()
                {
                    Title = tbNewTaskTitle.Text,
                    Description = tbNewTaskDescription.Text,
                    AssignedTo = Convert.ToInt32(cbNewTaskAssignedTo.Text.Split(',')[1].Split(':')[1]),
                    CreatedBy = Convert.ToInt32(Environment.GetEnvironmentVariable(Properties.Resources.UserInfo).Split('_')[0]),
                    Estimation = Convert.ToInt32(nudNewTaskEstinamtion.Value),
                    DateCreated = DateTime.Now,
                    DateLastModified = DateTime.Now,
                    Status = "New"
                };

                using (TManDBEntities entities = new TManDBEntities())
                {
                    entities.Database.Connection.Open();
                    entities.TMTasks.Add(newTask);
                    entities.SaveChanges();
                }

                MessageBox.Show("The task was successfuly created!", "Info", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("The task was not created! See more:\n"+ex.Message, "Info", MessageBoxButtons.OK);
            }
            finally
            {
                this.Close();
            }        
        }
    }
}
