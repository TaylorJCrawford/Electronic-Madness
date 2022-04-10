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
    public partial class frmnormal_q3 : Form
    {
        //Could hide one of the pic boxes

        UserClass playing_user;
        QuestionsClass timerlink;
        PictureBox drop_picture = new PictureBox();
        bool corrected = false;
        //true = right
        int imgchecker = 0;

        public frmnormal_q3(UserClass tempuser)
        {
            InitializeComponent();
            timerlink = new QuestionsClass();
            playing_user = tempuser;
        }

        //    frmfinal nextform = new frmfinal(playing_user);

        private void frmnormal_q3_Load(object sender, EventArgs e)
        {
            pbbattery_part01_match.AllowDrop = true;
            pbbulb_part02_match.AllowDrop = true;
            Countdown_frmnormalq3.Start();
        }

        //Battery----------------------------------------------------------------------(Drag & Drop)-----------------

        //drop step 2;
        private void pbbattery_part01_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedlabel = (PictureBox)sender;
            drop_picture = draggedlabel;
            imgchecker = 1;
            DoDragDrop(draggedlabel.Image, DragDropEffects.Copy);
        }
        //Step 3
        private void pbbattery_part01_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //Step 4
        private void pbbattery_part01_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (imgchecker == 1)
            {
                corrected = true;
            }
            else
            {
                corrected = false;
            }
            drop_picture.Image = null;
        }

        //Bulb----------------------------------------------------------------------------(Drag & Drop)-----------------

        //Step 2
        private void pbbulb_part02_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedlabel = (PictureBox)sender;
            drop_picture = draggedlabel;
            imgchecker = 2;
            DoDragDrop(draggedlabel.Image, DragDropEffects.Copy);
        }
        //Step 3
        private void pbbulb_part02_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //Step 4
        private void pbbulb_part02_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            if (imgchecker == 2)
            {
                corrected = true;
            }
            else
            {
                corrected = false;
            }
            drop_picture.Image = null;
        }


        //-----------------------

        private void btnsubmit_normalq3_Click(object sender, EventArgs e)
        {
            bool allow = false;

            if (pbbattery_part01_match.Image == null) 
            {
                MessageBox.Show("You need to fill in the battery box");
            }
            else if (pbbulb_part02_match.Image == null)
            {
                MessageBox.Show("You need to fill in the bulb box");
            }
            else if (corrected == true)
            {
                //right 
                MessageBox.Show("You are right, you have gained 4 points!");
                playing_user.Points += 4;
                allow = true;
            }
            else
            {
                //wrong
                MessageBox.Show("Sorry you are wrong, you have lost 2 point!");
                playing_user.Points -= 2;
                allow = true;
            }

            if (allow == true)
            {
                frmfinal nextform = new frmfinal(playing_user);
                Countdown_frmnormalq3.Stop();
                nextform.Show();
                this.Close();
            }

            //if (pbbattery_part01_match.Image == null || pbbulb_part02_match.Image == null)
            //{
            //    MessageBox.Show("You need to put fill in the battery symbol");
            //}
            // else if (pbbulb_part02_match.Image == Properties.Resources.img_Normal_circuits01__part2___Bulb_img && pbbattery_part01_match.Image == Properties.Resources.img_Normal_circuits01__part1___Battery)
            // {
            //     MessageBox.Show("You are right, you have gained 4 points!");
            //     playing_user.Points += 4;
            //     allow = true;
            // }
            // else
            // {
            //     MessageBox.Show("Sorry you are wrong, you have lost 2 point!");
            //     playing_user.Points -= 2;
            //     allow = true;
            // }


            
            //if (pbbattery_part01.Image == pbbattery_part01_match.Image && pbbulb_part02.Image == pbbulb_part02_match.Image)
            //{
                //right 100%
           // }                 
        }

        private void Countdown_frmnormalq3_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmnormalq3.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmfinal tempload = new frmfinal(playing_user);
                tempload.Show();
                this.Close();
            }
            else
            {
                lbltimer_normalq3.Text = templink;
            }
        }

        private void btnhelppage_frmnormalq3_Click(object sender, EventArgs e)
        {
            int formnum = 6;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close(); 
        }
    }
}
