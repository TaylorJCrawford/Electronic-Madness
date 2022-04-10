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
    public partial class frmnormal_q2 : Form
    {
        UserClass playing_user;
        QuestionsClass timerlink;
        string answer= "";

        public frmnormal_q2(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

    //    frmnormal_q3 nextform=new frmnormal_q3(playing_user);

        private void frmnormal_q2_Load(object sender, EventArgs e)
        {
            Countdown_frmnormalq2.Start();
            questionloader();
        }


        public void questionloader()
        {
            //This is loaidng the image into the pic box...
            //Need a way to chek the answer,,,, create a var at the top to store the right answer when the img loads...
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 || qnum01 == 9) //Sorten down also...
            {
                imgpicturebox_easyq3.Image = Properties.Resources.imgElectronic_Symbol__motor__01;
                answer = "motor";
            }
            else
            {
                imgpicturebox_easyq3.Image = Properties.Resources.imgElectronic_Symbol__positive_polarity__01;
                answer = "positive polarity";
            }
        }

        private void btnsubmit_easyq1_Click(object sender, EventArgs e)
        {
            string answer01 = answer;
            string submited_answer = txtuseranswer_easyq3.Text;
            bool next = false;

            //This will only work if the user enters the data in, in lower case
            //Extra [TO DO] Make sure if the user inputs in uper it will work
            if (submited_answer == answer01)
            {
                MessageBox.Show("You are right, you have gained 4 points!");
              playing_user.Points += 4;
              next = true;
            }
            else if (submited_answer== "")
            {
                MessageBox.Show("You need to input your answer");
                next = false;
            }
            else
            {
                MessageBox.Show("Sorry you are wrong, you have lost 2 point!");
              playing_user.Points -= 2;
              next = true;
            }

            if (next == true)
            {
                frmnormal_q3 nextform = new frmnormal_q3(playing_user);
                Countdown_frmnormalq2.Stop();
                nextform.Show();
                this.Close();
            }
        }

        private void Countdown_frmnormalq2_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmnormalq2.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmnormal_q3 tempload = new frmnormal_q3(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_normalq2.Text = timerlink.questiontimer();
            }
        }

        private void btnhelppage_frmnormalq2_Click(object sender, EventArgs e)
        {
            int formnum = 5;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }

        //key for answer
        //capacitor=1, 3, 5, 7, 9
        //battery= 2
        //three is wrong


    }
}
