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
    public partial class frmfinal : Form
    {
        UserClass playing_user;
        StoreUserClass users_being_stored;

        public frmfinal(UserClass tempuser) 
        {
            InitializeComponent();
            playing_user = tempuser;
            users_being_stored = new StoreUserClass();
        }

        private void frmfinal_Load(object sender, EventArgs e)
        {
            points_cal();
            //This form will display the points the user has scored and then pass the user to the main menu again
            //This form could 1. store the user 
            //2. pass the user again to the main menu
            Program.LoadObject(ref users_being_stored); //Try, catch
        }

        //Method for points
        public bool points_cal()
        {
            bool save = false;
            // true= user being saved
            int current_points= playing_user.Points;
            int highest_points= playing_user.Highestpoints;

            if (current_points > highest_points)
            {
                lblpoints_final.Text = "You have Scored: " + current_points + " Your new high score is: " + current_points;
                playing_user.Highestpoints = current_points;
                save = true;
            }
            else
            {
                lblpoints_final.Text = "You have Scored: " + current_points + " Your highset score is: " + highest_points;
            }
            return save;
        }

        private void btnmainmenu_final_Click(object sender, EventArgs e) //{TO ADD} Exiting will reset your socre back to 0; not your hight score;
        {
            save_user();
            frmmainmenu nextform= new frmmainmenu(playing_user);
            nextform.Show();
            this.Close();
        }

        //Save Point
        private void btnexit_final_Click(object sender, EventArgs e)
        {
            save_user();
            Application.Exit();
        }

        public void save_user()
        {
            bool save = false;
            save = points_cal();
            string playing_username = playing_user.Username;
            int playing_userpoints = playing_user.Points;

            if (save == true) //update the current users 
            {
                //load user array disk
                users_being_stored.update_userspoints(playing_username, playing_userpoints);
                Program.SaveObject(users_being_stored); //Save the user 
            }
            playing_user.Points = 0;
        }
    }
}
