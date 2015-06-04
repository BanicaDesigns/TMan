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
                
                var entities = new TManDBEntities();
                var userIsAvailableInDatabase = (from el in entities.TMUsers
                                                where el.Username == tbUsernameInput.Text && el.Password == tbPasswordInput.Text
                                                select el).Any();

                var userIsAdministrator = userIsAvailableInDatabase && (from el in entities.TMUsers
                                                                        where   el.Username == tbUsernameInput.Text 
                                                                            &&  el.Password == tbPasswordInput.Text
                                                                            &&  el.Role == "Administrator"
                                                                        select el).Any();

                if (userIsAvailableInDatabase && userIsAdministrator)
                {
                    this.Hide();
                    var adminDialog = new AdministratorDialog();
                    adminDialog.ShowDialog();
                }
                else if (userIsAvailableInDatabase && !userIsAdministrator)
                {
                    this.Hide();
                    RegularUserDialog regularDialog = new RegularUserDialog();
                    regularDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User is not available in the database! Try with another one or different credentials.", "Message");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("There was a fatal error while trying to log you in. See more:\n{0}", ex.Message));
            }
        }
    }
}
