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
    public partial class frmeasy_q1 : Form
    {
        QuestionsClass timerlink;
        UserClass playing_user;
        private int answer;

        public frmeasy_q1 (UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
            answer = 0;
        }

        private void frmeasy_q1_Load(object sender, EventArgs e)
        {
            Countdown_frmeasyq1.Start();
            questionloader();
        }

        private void Countdown_frmeasyq1_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmeasyq1.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmeasy_q2 nextform = new frmeasy_q2(playing_user);
                nextform.Show();
                this.Close();
            }
            else
            {
                lbltimer_easyq1.Text = timerlink.questiontimer();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Method to chosse and load one from random. 
        }

        public void questionloader()
        {
            //This is loaidng the image into the pic box...
            //Need a way to chek the answer,,,, create a var at the top to store the right answer when the img loads...
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 ||qnum01== 9) //Sorten down also...
            {
                imgpicturebox_easyq1.Image = Properties.Resources.imgElectronic_Symbol__Battery;
                answer = 1; 
            }
            else
            {
                imgpicturebox_easyq1.Image = Properties.Resources.imgElectronic_Symbol__Buzzer;
                answer = 2;
            }

                //key for answer
                //battery=1, 3, 5, 7, 9
                //buzzer= 2
                //three is wrong           
        }

        private void btnsubmit_easyq1_Click(object sender, EventArgs e)
        {
            int answer01 = answer;
            int submited_answer = 0;
            bool next = false;

            if (rbbattery_easyq1.Checked)
            {
                submited_answer = 1;
            }
            else if (rbbuzzer_easyq1.Checked)
            {
                submited_answer = 2;
            }
            else if (rbcapacitor_easyq1.Checked || rbelectricbell_easyq1.Checked)
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
                MessageBox.Show("You are right, you have gained 2 points!");
                playing_user.Points += 2;
                next = true;
            }
            else if (submited_answer == 0)
            {
                //No Answer
                MessageBox.Show("You need to select an answer!");
            }
            else
            {
                // -1 point wrong
                MessageBox.Show("Sorry you are wrong, you have lost 1 point!");
                playing_user.Points -= 1;
                next = true;
            }
            if (next == true)
            {
                frmeasy_q2 nextform = new frmeasy_q2(playing_user);
                Countdown_frmeasyq1.Stop();
                nextform.Show();
                this.Close();
            }
        }

        private void btnhelppage_mainmenu_Click(object sender, EventArgs e)
        {
            //Need a way to pass the user to the next form here+
            //record witch form a came from to get to the help page.
            int formnum = 1;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close();   //This will close so the user gets a differnet question to load
        }
    }
}
