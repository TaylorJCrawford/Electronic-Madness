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
    public partial class frmhard_q1 : Form
    {
        QuestionsClass timerlink;
        UserClass playing_user;
        int answer = 0;

        public frmhard_q1(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

    //    frmhard_q2 nextform=new frmhard_q2(playing_user);

        private void frmhard_q1_Load(object sender, EventArgs e)
        {
            Countdown_frmhardq1.Start();
            questionloader();
        }

        public void questionloader()
        {
            //This is loaidng the image into the pic box...
            //Need a way to chek the answer,,,, create a var at the top to store the right answer when the img loads...
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 || qnum01 == 9) //Sorten down also...
            {
                imgpicturebox_hardq1.Image = Properties.Resources.img_ground_symbol;
                answer = 1;
            }
            else
            {
                imgpicturebox_hardq1.Image = Properties.Resources.img_frequencymeter_symbol;
                answer = 2;
            }
        }

        private void Countdown_frmhardq1_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmhardq1.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmhard_q2 tempload = new frmhard_q2(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_hardq1.Text = timerlink.questiontimer();
            }
        }

        private void btnsubmit_hardq1_Click(object sender, EventArgs e)
        {
            int answer01 = answer;
            int submited_answer = 0;
            bool next = false;

            if (rbground_hardq1.Checked)
            {
                submited_answer = 1;
            }
            else if (rbfrequencymeter_hardq1.Checked)
            {
                submited_answer = 2;
            }
            else if (rbcapacitor_hardq1.Checked || rbmotor_hardq1.Checked)
            {
                submited_answer = 3;
            }
            else
            {
                submited_answer = 0;
            }

            if (submited_answer == answer01)
            {
                //2+ point right
                MessageBox.Show("You are right, you have gained 6 points!");
                playing_user.Points += 6;
                next = true;
            }
            else if (submited_answer == 0)
            {
                MessageBox.Show("You need to select an answer!");
            }
            else
            {
                // -1 point wrong
                MessageBox.Show("Sorry you are wrong, you have lost 3 point!");
                playing_user.Points -= 3;
                next=true;
            }

            if (next == true)
            {
                frmhard_q2 nextform = new frmhard_q2(playing_user);
                Countdown_frmhardq1.Stop();
                nextform.Show();
                this.Close();
            }
        }

        private void btnhelppage_frmhardq1_Click(object sender, EventArgs e)
        {
            int formnum = 7;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }

    }
}
