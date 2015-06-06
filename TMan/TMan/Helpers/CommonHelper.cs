using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMan.Helpers
{
    public static class CommonHelper
    {
        public static void PopulateComboboxWithAllUsers(ComboBox combo, TManDBEntities entities)
        {
            var allAvailableUsers = from user in entities.TMUsers
                                    select new { Username = user.Username, UserId = user.UserId };

            foreach (var user in allAvailableUsers)
                combo.Items.Add(string.Format(Properties.Resources.USER_IN_LAYOUT_TEMPL, user.Username, user.UserId));
        }
    }
}
