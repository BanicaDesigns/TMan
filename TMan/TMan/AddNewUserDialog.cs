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
    public partial class AddNewUserDialog : Form
    {
        public AddNewUserDialog()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new TMUser()
                {
                    Username = tbNewUserUserName.Text,
                    Password = tbNewUserPassword.Text,
                    Role = cbNewUserRole.Text
                };

                using (TManDBEntities entities = new TManDBEntities())
                {
                    entities.Database.Connection.Open();
                    entities.TMUsers.Add(newUser);
                    entities.SaveChanges();
                }

                MessageBox.Show("The user was successfuly created!", "Info", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The user was not created! See more:\n" + ex.Message, "Info", MessageBoxButtons.OK);
            }
            finally
            {
                this.Close();
            } 
        }
    }
}
