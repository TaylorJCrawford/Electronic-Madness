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
    public partial class frmnormal_q1 : Form
    {
        QuestionsClass timerlink;
        UserClass playing_user;
        int answer;

        public frmnormal_q1(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
            answer = 0;
        }

        private void Countdown_frmnormalq1_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmnormalq1.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmnormal_q2 tempload = new frmnormal_q2(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_normalq1.Text = timerlink.questiontimer();
            }
        }

        private void frmnormal_q1_Load(object sender, EventArgs e)
        {
            Countdown_frmnormalq1.Start();
            questionloader();
        }

        public void questionloader()
        {
            //This is loaidng the image into the pic box...
            //Need a way to chek the answer,,,, create a var at the top to store the right answer when the img loads...
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 || qnum01 == 9) //Sorten down also...
            {
                imgpicturebox_normalq1.Image = Properties.Resources.imgElectronic_Symbol__Capacitor;
                answer = 1;
            }
            else
            {
                // elec bell
                imgpicturebox_normalq1.Image = Properties.Resources.imgElectronic_symbol_bell;
                answer = 2;
            }

            //key for answer
            //battery=1, 3, 5, 7, 9
            //buzzer= 2
            //three is wrong           
        }

        private void btnsubmit_normalq1_Click(object sender, EventArgs e)
        {
            int answer01 = answer;
            int submited_answer = 0;
            bool next = false;

            if (rbcapacitor_normalq1.Checked)
            {
                submited_answer = 1;
            }
            else if (rbelectricbell_normalq1.Checked)
            {
                submited_answer = 2;
            }
            else if (rbtransistor_normalq1.Checked || rbbattery_normalq1.Checked)
            {
                submited_answer = 3;
            }
            else
            {
                submited_answer = 0;
            }
           
            if (submited_answer == answer01)
            {
                MessageBox.Show("You are right, you have gained 4 points!");
                playing_user.Points += 4;
                next = true;
            }
            else if (submited_answer == 0) 
            {
                MessageBox.Show("You need to select an answer!"); 
            }
            else
            {
                MessageBox.Show("Sorry you are wrong, you have lost 2 point!");
                playing_user.Points -= 2;
                next = true;
            }

            if (next == true)
            {
                frmnormal_q2 nextform = new frmnormal_q2(playing_user);
                Countdown_frmnormalq1.Stop();
                nextform.Show();
                this.Close();
            }
        }

        private void btnhelppage_frmnormalq1_Click(object sender, EventArgs e)
        {
            int formnum = 4;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }
    }
}
