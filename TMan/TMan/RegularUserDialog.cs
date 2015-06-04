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
    }
}
