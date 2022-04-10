using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Electronic_Madness
{
    public partial class frmhelppage : Form
    {
        int formreturn=0;
        UserClass playing_user;

        public frmhelppage(int tempnum, UserClass tempuser)  
        {
            InitializeComponent();
            formreturn = tempnum;
            playing_user = tempuser;          
        }

        private void btnback_helppage_Click(object sender, EventArgs e)
        {
            //Could do a case statment to show the from the user came from

            //Put into class, pass in the form number + playing user and then close the form at the end...

            switch (formreturn)
            {
                case 1: 
                    {
                        frmeasy_q1 nextform= new frmeasy_q1(playing_user); //pass in the form name as a parmeter and access the method to load the form
                        nextform.Show();
                        this.Close();
                    } break;

                case 2: 
                    {
                        frmeasy_q2 nextform = new frmeasy_q2(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 3: 
                    {
                        frmeasy_q3 nextform = new frmeasy_q3(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 4: 
                    {
                        frmnormal_q1 nextform = new frmnormal_q1(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 5: 
                    {
                        frmnormal_q2 nextform = new frmnormal_q2(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 6: 
                    {
                        frmnormal_q3 nextform = new frmnormal_q3(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 7: 
                    {
                        frmhard_q1 nextform = new frmhard_q1(playing_user);
                        nextform.Show();
                        this.Close();
                    } break;

                case 8: 
                    {
                        frmhard_q2 nextfrom = new frmhard_q2(playing_user);
                        nextfrom.Show();
                        this.Close();
                    } break;

                case 9: 
                    {
                        frmhard_q3 nextfrom = new frmhard_q3(playing_user);
                        nextfrom.Show();
                        this.Close();
                    } break;
            }
        }

        private void frmhelppage_Load(object sender, EventArgs e)
        {
  //          string text = File.ReadAllText("unformatted textfile.txt.");
//            txthelppage_textbox.Text = (text);
           // @"C:\users\Taylor\Documents\SSD Coursework\Electronic Madness\Electronic Madness\bin\Debug\
        }

        private void btnelectronicsymbols_helppage_Click(object sender, EventArgs e)
        {
            int hide = 1;
            hide_circuits(hide);
            pictureboxloader_helppage.Image = Properties.Resources.help_page__1_electric_symbols_;
            playing_user.Points -= 1;
        }

        private void btnbasiccomponetns_helppage_Click(object sender, EventArgs e)
        {
            int hide= 1;
            hide_circuits(hide);
            pictureboxloader_helppage.Image = Properties.Resources.help_page__2_basic_Components;
            playing_user.Points -= 1;
        }

        private void btncircuits_helppage_Click(object sender, EventArgs e)
        {
            //Not working----------------------------------------------------- //text file.
            int show= 2;
            playing_user.Points -= 1;
            hide_circuits(show);
            string text = "";
           text = File.ReadAllText("text file.txt");
            txthelppage_textbox.Text = text;
            pbcircuits_helppage.Image = Properties.Resources.electric_circuits_help_page__3_1;
            
        }
        public void hide_circuits(int hider_show)//hide = 1, show = 2;
        {
            if (hider_show == 1)
            {
                txthelppage_textbox.Hide();
                pbcircuits_helppage.Hide();
            }
            else
            {
                txthelppage_textbox.Show();
                pbcircuits_helppage.Show();
            }
        }
    }
}
