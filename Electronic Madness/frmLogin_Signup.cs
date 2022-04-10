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
    public partial class frmLogin_Signup : Form
    {
        StoreUserClass newuser;//1
        UserClass playing_user;

        public frmLogin_Signup()
        {
            InitializeComponent();
            newuser = new StoreUserClass();
            playing_user = new UserClass();
        }

        private void frmLogin_Signup_Load(object sender, EventArgs e)
        {
            //Try, catch- if there is no array to load...{To Add}
           Program.LoadObject(ref newuser);//1
           //newuser = new StoreUserClass(); //{clearing array}- del file (mydata.dat), uncomment this line and then comment loadobject... 
        }

        private void lblusernamelogin_login_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_login_Click(object sender, EventArgs e)
        {
            bool allowuser= false;
            string username01= txtusernamelogin_loginform.Text;
            string password01= txtpasswordlogin_login.Text;

            //add method to validate the txtboxes. Check witch data has not been entered...
            if (username01 == string.Empty)
            {
                MessageBox.Show("You must enter a username in the textbox");
            }
            else if (password01 == string.Empty)
            {
                MessageBox.Show("You must enter a password in the textbox");
            }
            else
            {
                allowuser = newuser.checkuserpass(username01, password01);
            }

            if (allowuser == true)
            {
                frmmainmenu nextform = new frmmainmenu(playing_user);
                nextform.Show();
                this.Close();
            }
        }

        private void txtmailcreate_login_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncreate_login_Click(object sender, EventArgs e)
        {
            UserClass newuser02= new UserClass();
            bool cheker = false;
            string email01 = txtmailcreate_login.Text;
            string username01 = txtusernamecreate_loginform.Text;
            string password01_01 = txtpasswordcreate01_login.Text;
            string password01_02 = txtpasswordcreate02_login.Text;

            //check 1 
            //ass
            if (username01==string.Empty)
            {
                MessageBox.Show("You must enter a username");
            }
            else if (email01==string.Empty)
            {
                MessageBox.Show("You must enter an email address");
            }
            else if(password01_01==string.Empty)
            {
                MessageBox.Show("You must enter a password");
            }
            else if(password01_02==string.Empty)
            {
                MessageBox.Show("You must conferm your password"); //check spelling 
            }
            else
            {
                cheker = newuser.CheckuserData(email01, username01, password01_01, password01_02);
            }

            if (cheker == true)
            {

                newuser02.Email = email01;
                newuser02.Username = username01;
                newuser02.Password = password01_01;
                newuser.Adduser(newuser02);
                newuser02.Points = 0;
                frmmainmenu nextform02 = new frmmainmenu(playing_user);
                Program.SaveObject(newuser); //Do i need to load the array first, before saving??????????????????????????????
                MessageBox.Show("A new user has been added");
                nextform02.Show();
                this.Close();
            }
        }

        private void txtusernamecreate_loginform_TextChanged(object sender, EventArgs e)
        {

        }


        //This is a tmepbutton for testing
        private void tempbutton_Click(object sender, EventArgs e)
        {
            frmmainmenu temp01 = new frmmainmenu(playing_user);
            temp01.Show();
        }
    }
}
