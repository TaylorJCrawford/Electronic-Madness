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
    public partial class frmmainmenu : Form
    {
        //Points 
        //Easy= right +2, wrong -1;
        //Normal= right +4, wrong -2;
        //Hard= right +6, wrong -3; 
        
        DateTime date;
        QuestionsClass getform;
        UserClass playing_user;
        //int userstartpoints; //Testing
        StoreUserClass users_beingsotred;

        public frmmainmenu(UserClass tempuser)
        {
            InitializeComponent();
            playing_user = tempuser;
            date = DateTime.Now.Date;
            getform = new QuestionsClass();
            Program.LoadObject(ref users_beingsotred);
        //StoreUserClass newuser;//02- Listbox
        }

        //playinguser.points=
       // playing_user.<need>

        private void frmmainmenu_Load(object sender, EventArgs e)
        {
            //This lbl is displaying the current date in a label
            lblcurrnendataandtime_mainmenu.Text = string.Format("{0:dd/MM/yyyy}", date);
            //lblgamename_mainmenu.Text = Convert.ToString(playing_user.Highestpoints); //Testing use-------

            users_beingsotred.listoftop_5_players(ref listBoxhighscore_mainmenu);




            timer_mainmenu.Start();
            //userstartpoints = playing_user.Points; //Testing
            
           //Listbox---------------------------
            //Program.LoadObject(ref users_beingsotred);// //02- Listbox
           //users_beingsotred.listoftop_5_players(ref listBoxhighscore_mainmenu); //02- Listbox

            //Need method to add the users to list box[[ADD]]
            //StoreUserClass top_players = new StoreUserClass();
            // top_players.listoftop_5_players(ref listBoxhighscore_mainmenu);
        }

        private void btnexit_mainmenu_Click(object sender, EventArgs e)
        {
            timer_mainmenu.Stop();
            Application.Exit();
        }

        private void btnstart_mainmenu_Click(object sender, EventArgs e)
        {
            if (rbeasy_mainmenu.Checked ==true)
                getform.Questionfrmcheker = 1;
            else if (rbhard_mainmenu.Checked == true)
                getform.Questionfrmcheker = 2;
            else
                getform.Questionfrmcheker = 3;

            getform.mainmenuchosse(playing_user);
            timer_mainmenu.Stop();
            this.Hide();
        }

        private void timer_mainmenu_Tick(object sender, EventArgs e)
        {
            lbltime_mainmenu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void listBoxhighscore_mainmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To add users to listboxs...
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
