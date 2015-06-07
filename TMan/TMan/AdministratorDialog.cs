using System;
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
    public partial class AdministratorDialog : RegularUserDialog
    {
        private string SelectedUserCredentialsSerialized;

        public AdministratorDialog()
        {
            InitializeComponent();
        }

        private void AdministratorDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabUsersManagement_Click(object sender, EventArgs e)
        {
            
        }

        private void tabUsersManagement_Enter(object sender, EventArgs e)
        {
            using (TManDBEntities entities = new TManDBEntities())
            {
                cbAllUsers.Items.Clear();
                CommonHelper.PopulateComboboxWithAllUsers(cbAllUsers, entities);
            }
        }

        private void cbAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userId = Convert.ToInt32(((System.Windows.Forms.ComboBox)(sender)).SelectedItem.ToString().Split(',')[1].Split(':')[1]);

            using (TManDBEntities entities = new TManDBEntities())
            {
                var userFromDatabase = (from user in entities.TMUsers
                                        where user.UserId == userId
                                        select user).FirstOrDefault();

                FillUpBasicUserInformation(userFromDatabase);

                SelectedUserCredentialsSerialized = string.Format(Properties.Resources.USER_SERIALIZED_TEMPL
                                                                , userFromDatabase.UserId
                                                                , userFromDatabase.Username
                                                                , userFromDatabase.Password
                                                                , userFromDatabase.Role);
            }            
        }

        private void FillUpBasicUserInformation(TMUser userFromDatabase = null)
        {
            tbUserName.Text = userFromDatabase != null ? userFromDatabase.Username : string.Empty;
            tbPassword.Text = userFromDatabase != null ?userFromDatabase.Password : string.Empty;
            cbRole.Text = userFromDatabase != null ?userFromDatabase.Role : string.Empty;
            tbId.Text = userFromDatabase != null ?userFromDatabase.UserId.ToString() : string.Empty;
        }

        private void btnSaveUserChanges_Click(object sender, EventArgs e)
        {
            var latestUserValuesSerialized = string.Format(Properties.Resources.USER_SERIALIZED_TEMPL
                                                                , tbId.Text
                                                                , tbUserName.Text
                                                                , tbPassword.Text
                                                                , cbRole.Text);
            if (this.SelectedUserCredentialsSerialized == latestUserValuesSerialized)
                return;
           
            try
            {
                using (TManDBEntities entities = new TManDBEntities())
                {
                    entities.Database.Connection.Open();

                    var latestUserValuesSerializedSplitted = latestUserValuesSerialized.Split('_');

                    var user = new TMan.TMUser
                    {
                        UserId = Convert.ToInt32(latestUserValuesSerializedSplitted[0]),
                        Username = latestUserValuesSerializedSplitted[1],
                        Password = latestUserValuesSerializedSplitted[2],
                        Role = latestUserValuesSerializedSplitted[3]
                    };

                    entities.TMUsers.Attach(user);
                    entities.Entry(user).State = EntityState.Modified;
                    entities.SaveChanges();
                }


                MessageBox.Show("Update was successful!", "Info", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed", "Info", MessageBoxButtons.OK);
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var addNewUserDialog = new AddNewUserDialog();
            addNewUserDialog.ShowDialog();

            using (TManDBEntities entities = new TManDBEntities())
            {
                cbAllUsers.Items.Clear();
                CommonHelper.PopulateComboboxWithAllUsers(cbAllUsers, entities);
            }

            FillUpBasicUserInformation();
        }


    }
}
