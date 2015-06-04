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
                //Ако потребителят съществува в базата и е администратор -> Зареди екрана за администратори
                //Ако потребителят съществува в базата и не е администра -> Зареди екрана за обикновени потр.
                //Ако потребителят не съществува -> MessageBox.Show("User doesn't exist");
                this.Hide();
                if (tbUsernameInput.Text == "holla" && tbPasswordInput.Text == "123")
                {
                    AdministratorDialog adminDialog = new AdministratorDialog();
                    adminDialog.ShowDialog();
                }
                else
                {
                    RegularUserDialog regularDialog = new RegularUserDialog();
                    regularDialog.ShowDialog();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was a fatal error while trying to log you in. See more:\n", ex.Message);
            }
        }
    }
}
