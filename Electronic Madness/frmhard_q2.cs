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
    public partial class frmhard_q2 : Form
    {
        UserClass playing_user;
        QuestionsClass timerlink;
        string answer = "";


        public frmhard_q2(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

    //    frmhard_q3 nextform=new frmhard_q3(playing_user);

        private void frmhard_q2_Load(object sender, EventArgs e)
        {
            Countdown_frmhardq2.Start();
            questionloader();
        }

        public void questionloader()
        {
            //This is loaidng the image into the pic box...
            //Need a way to chek the answer,,,, create a var at the top to store the right answer when the img loads...
            int qnum01 = timerlink.Randomnumber_gen();
            if (qnum01 == 1 || qnum01 == 3 || qnum01 == 5 || qnum01 == 7 || qnum01 == 9) //Sorten down also...
            {
                imgpicturebox_hardq2.Image = Properties.Resources.img_transformer;
                answer = "transformer";
            }
            else
            {
                imgpicturebox_hardq2.Image = Properties.Resources.img_antenna_symbol;
                answer = "antenna"; //Check sp & g
            }
        }

        private void btnsubmit_hardq2_Click(object sender, EventArgs e)
        {
            string answer01 = answer;
            string submited_answer = txtuseranswer_hardq2.Text;
            bool next = false;

            //This will only work if the user enters the data in, in lower case
            //Extra [TO DO] Make sure if the user inputs in uper it will work
            if (submited_answer == answer01)
            {
                // 2+ point right
                MessageBox.Show("You are right, you have gained 6 points!");
                playing_user.Points += 6;
                next = true;
            }
            else if (submited_answer == "")
            {
                MessageBox.Show("You need to input your answer");
                next = false;
            }
            else
            {
                // -1 point wrong
                MessageBox.Show("Sorry you are wrong, you have lost 3 point!");
                playing_user.Points -= 3;
                next = true;
            }
            if (next == true)
            {
                frmhard_q3 nextform = new frmhard_q3(playing_user);
                Countdown_frmhardq2.Stop();
                nextform.Show();
                this.Close();
            }
        }

        private void Countdown_frmhardq2_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmhardq2.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmhard_q3 tempload = new frmhard_q3(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_hardq2.Text = timerlink.questiontimer();
            }
        }

        private void btnhelppage_frmhardq2_Click(object sender, EventArgs e)
        {
            int formnum = 8;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }
    }
}
