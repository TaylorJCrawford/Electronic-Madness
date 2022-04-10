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
    public partial class frmeasy_q3 : Form
    {
        QuestionsClass timerlink;
        UserClass playing_user;
        bool corrected = false;
        int imgchecker = 0;

        public frmeasy_q3(UserClass tempuser )
        {
            InitializeComponent();
            playing_user = tempuser;
            timerlink = new QuestionsClass();
        }

        private void frmeasy_q3_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            imgpicturebox_easyq3_part01_match.AllowDrop = true;
            Countdown_frmeasyq3.Start();
        }

        private void imgpicturebox_easyq3_part01_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox draggedPicture = (PictureBox)sender;
            DoDragDrop(draggedPicture.Image, DragDropEffects.Copy);
            imgchecker = 1;
        }

        private void imgpicturebox_easyq3_part01_match_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect &DragDropEffects.Copy) !=0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect= DragDropEffects.Copy;
            else 
                e.Effect= DragDropEffects.None;
        }

        private void imgpicturebox_easyq3_part01_match_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgpicturebox_easyq3_part01.Image = null;
        }

        private void btnsubmit_easyq3_Click(object sender, EventArgs e)
        {
            if (imgchecker == 1)
            {
                corrected = true;
            }
            else
            {
                corrected = false;
            }

            bool next = false;
            //imgpicturebox_easyq3_part01_match.Image == Properties.Resources.img_Easy_circuits01_01__Part1___Battery_jpg
            
            if (corrected==true)
            {
                //Right +2
                MessageBox.Show("You are right, you have gained 2 points!");
                playing_user.Points += 2;
                next = true;
            }
            else
            if (imgpicturebox_easyq3_part01_match.Image == null)
               MessageBox.Show("Please input pic into box");
            /*else if (corrected == false)
            {
                //Wrong -1 this will not be used could just delete it...
                MessageBox.Show("Sorry you are wrong, you have lost 1 point!");
                playing_user.Points -= 1;
                next = true;
            }
            */
            if (next == true)
            {
                frmfinal nextfrom = new frmfinal(playing_user);
                Countdown_frmeasyq3.Stop();
                nextfrom.Show();
                this.Close();
            }
        }

        private void Countdown_frmeasyq3_Tick(object sender, EventArgs e)
        {
            string templink = timerlink.questiontimer();
            if (templink == string.Empty)
            {
                Countdown_frmeasyq3.Stop();
                MessageBox.Show("You didn't finish in time. ", "Sorry!");
                frmfinal nextform = new frmfinal(playing_user);
                nextform.Show();
                this.Close();
            }
            else
            {
                lbltimer_easyq3.Text = timerlink.questiontimer();
            }
        }

        private void btnhelppage_frmeasyq3_Click(object sender, EventArgs e)
        {
            int formnum = 3;
            frmhelppage opener = new frmhelppage(formnum, playing_user);
            opener.Show();
            this.Close();
        }
    }
}
