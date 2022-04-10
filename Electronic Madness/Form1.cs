using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Madness
{
    public partial class frmLoading_Form : Form
    {
        int waittime;
        public frmLoading_Form()
        {
            InitializeComponent();
            waittime = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            //This is used to set the progress bar values.
            pgbloadingform.Minimum = 0;
            pgbloadingform.Maximum = 100;
            Loadingfrom_timer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pgbloadingform_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waittime++;
            if (pgbloadingform.Value < 100)
                pgbloadingform.Value++;
            else
                if (waittime == 150)
                {
                    Loadingfrom_timer.Stop();
                    Form nextForm = new frmLogin_Signup();
                    this.Hide();
                    nextForm.Show();
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Could load key points in dointg the quiz...
            //You can get more points on the harder levels
        }
    }
}
