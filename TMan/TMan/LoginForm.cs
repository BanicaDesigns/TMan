using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMan;
using TMan.Helpers;

namespace TMan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (TManDBEntities entities = new TManDBEntities())
                {
                    entities.Database.Connection.Open();

                    var userFromDatabase = (from el in entities.TMUsers
                                                     where el.Username == tbUsernameInput.Text && el.Password == tbPasswordInput.Text
                                                     select el).FirstOrDefault();

                    AuthenticateUser(userFromDatabase);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("There was a fatal error while trying to log you in. See more:\n{0}", ex.Message));
            }
        }

        private void AuthenticateUser(TMan.TMUser user)
        {
            if (user!=null)
            {
                this.Hide();
                SaveTheUserInfoIntoEnvironmentVariable(user.UserId, user.Username, user.Password, user.Role);

                if (user.Role == UserRolesEnum.Administrator.ToString())
                {   
                    var adminDialog = new AdministratorDialog();
                    adminDialog.ShowDialog();
                }
                else
                {
                    RegularUserDialog regularDialog = new RegularUserDialog();
                    regularDialog.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("User is not available in the database! Try with another one or different credentials.", "Message");
            }
        }

        private void SaveTheUserInfoIntoEnvironmentVariable(int id, string name, string password, string role)
        {
            Environment.SetEnvironmentVariable(Properties.Resources.UserInfo, string.Format("{0}_{1}_{2}_{3}"
                                                            , id, name, password,role));
        }
    }
}
