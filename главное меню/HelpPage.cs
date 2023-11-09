using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator
{
    public partial class HelpPage : Form
    {
        private bool cl = true;

        public HelpPage()
        {
            InitializeComponent();
        }

        private void backmenu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new SystemMenu();
            sysmenu.Show();
            this.Close();
        }

        private void HelpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                Application.Exit();
            }
        }
    }
}
