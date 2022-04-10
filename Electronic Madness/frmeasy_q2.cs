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
    public partial class frmeasy_q2 : Form
    {
        public frmeasy_q2()
        {
            InitializeComponent();
        }

        private void frmeasy_q2_Load(object sender, EventArgs e)
        {
            Countdown_frmeasyq2.Start();
            questionloader();
        }

        QuestionsClass timerlink;
        UserClass playing_user;
        string answer = "";

        public frmeasy_q2 (UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

        private void countdown_frmeasyq2_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmeasyq2.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmeasy_q3 tempload = new frmeasy_q3(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_easyq2.Text = timerlink.questiontimer();
            }
        }

        public void questionloader()
        {
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 || qnum01 == 9)
            {
                imgpicturebox_easyq2.Image = Properties.Resources.imgElectronic_Symbol__Ammeter__01;
                answer = "ammeter";
            }
            else
            {
                imgpicturebox_easyq2.Image = Properties.Resources.imgElectronic_Symbol__Voltmeter__01;
                answer = "voltmeter";
            }
        }

        private void btnsubmit_easyq2_Click(object sender, EventArgs e)
        {
            string answer01 = answer;
            string submited_answer = txtuseranswer_easyq2.Text;
            bool next = false;

            if (submited_answer == answer01)
            {
                //Answer is right
                MessageBox.Show("You are right, you have gained 2 points!");
                playing_user.Points += 2;
                next = true;
            }
            else if(submited_answer=="")
            {
                MessageBox.Show("You need to input your answer");
                next = false;
            }
            else
            {
                //Answer is wrong
                MessageBox.Show("Sorry you are wrong, you have lost 1 point!");
                playing_user.Points -= 1;
                next = true;
            }

            if (next == true)
            {
                frmeasy_q3 nextfrom = new frmeasy_q3(playing_user);
                Countdown_frmeasyq2.Stop();
                nextfrom.Show();
                this.Close();
            }
        }

        private void btnhelppage_frmeasyq2_Click(object sender, EventArgs e)
        {
            int formnum = 2;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close();
        }
    }
}
