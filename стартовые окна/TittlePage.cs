using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_Simulator
{

    public partial class TittlePage : Form
    {
        private bool cl = true;
        public TittlePage()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            cl = false;
            SystemMenu sysmenu = new();
            sysmenu.Show();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
                Application.Exit();
        }

        private void TittlePage_Click(object sender, EventArgs e)
        {
            cl = false;
            TittlePage2 tittle2 = new();
            tittle2.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            date.Text = DateTime.Now.ToShortDateString();
        }
    }
}
