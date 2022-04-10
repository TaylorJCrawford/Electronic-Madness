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
    public partial class frmhard_q3 : Form
    {
        QuestionsClass timerlink;
        UserClass playing_user;
        PictureBox drop_picture = new PictureBox();
        bool corrected01 = false;
        bool corrected02 = false;
        bool corrected03 = false;
        int imgchecker = 0;

        public frmhard_q3()
        {
            InitializeComponent();
        }

        public frmhard_q3(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

    //    frmfinal nextform =new frmfinal(playing_user);

        private void frmhard_q3_Load(object sender, EventArgs e)
        {
          pbmotor_part1_match.AllowDrop = true;
          pbvoltmeter_part2_match.AllowDrop = true;
          pbresistor_part3_match.AllowDrop = true;
            Countdown_frmhardq3.Start();
        }

        private void Countdown_frmhardq3_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmhardq3.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmfinal tempload = new frmfinal(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_hardq3.Text = timerlink.questiontimer();
            }
        }

        //Motor Step2 ------------------------------------------
        private void imgmotor_part1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedPicture = (PictureBox)sender;
            drop_picture = draggedPicture;
            imgchecker = 1;
            DoDragDrop(draggedPicture.Image, DragDropEffects.Copy);
        }

        //Motor Step3
        private void imgmotor_part1_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void imgmotor_part1_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (imgchecker == 1)
            {
                corrected01 = true;
            }
            else
            {
                corrected01 = false;
            }
            drop_picture.Image = null;
        }

        //Voltmeter Step2-----------------------------------------
        private void imgvoltmeter_part2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedPicture = (PictureBox)sender;
            drop_picture = draggedPicture;
            imgchecker = 2;
            DoDragDrop(draggedPicture.Image, DragDropEffects.Copy);
        }

        //step3
        private void imgvoltmeter_part2_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void imgvoltmeter_part2_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (imgchecker == 2)
            {
                corrected02 = true;
            }
            else
            {
                corrected02 = false;
            }
            drop_picture.Image = null;
        }

        //Resistor step2---------------------------------------------------------
        private void imgresistor_part3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedPicture = (PictureBox)sender;
            drop_picture = draggedPicture;
            imgchecker = 3;
            DoDragDrop(draggedPicture.Image, DragDropEffects.Copy);
        }

        private void imgresistor_part3_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void imgresistor_part3_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (imgchecker == 3)
            {
                corrected03 = true;
            }
            else
            {
                corrected03 = false;
            }
            drop_picture.Image = null;
        }

        private void btnhelppage_frmhardq3_Click(object sender, EventArgs e)
        {
            int formnum = 9;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }

        private void btnsubmit_hardq3_Click(object sender, EventArgs e)
        {
            bool allow = false;

            if (pbmotor_part1_match.Image == null && pbvoltmeter_part2_match.Image == null && pbresistor_part3_match.Image == null)
            {
                MessageBox.Show("You need to fill in all slots");
            }
            else
            if (pbmotor_part1_match.Image == null)
            {
                MessageBox.Show("You need to fill in the motor slot"); //one for each
            }
            else if (pbvoltmeter_part2_match.Image == null)
            {
                MessageBox.Show("You need to fill in the voltmeter slot");
            }
            else if (pbresistor_part3_match.Image == null)
            {
                MessageBox.Show("You need to fill in the resistor slot");
            }
            else if (corrected01 == true && corrected02 == true && corrected03 == true)
            {
                //right 
                MessageBox.Show("You are right, you have gained 6 points!");
                playing_user.Points += 6;
                allow = true;
            }
            else
            {
                //wrong
                MessageBox.Show("Sorry you are wrong, you have lost 3 point!");
                playing_user.Points -= 3;
                allow = true;
            }

            if (allow == true)
            {
                frmfinal nextform = new frmfinal(playing_user);
                Countdown_frmhardq3.Stop();
                nextform.Show();
                this.Close();
            }



            if (pbmotor_part1_match.Image == Properties.Resources.img_Hard_circuits01__part1___motor_jpg && pbresistor_part3_match.Image == Properties.Resources.img_Hard_circuits01__part3___resistor && pbvoltmeter_part2_match.Image == Properties.Resources.img_Hard_circuits01__part2___volmeter)
            {
                //right 100%
            }
            else if (pbmotor_part1_match.Image == null || pbvoltmeter_part2_match.Image == null || imgresistor_part3.Image == null)
            {
                //not enter all boxes
            }
            else
            {
                //wrong 
            }
        }
    }
}
