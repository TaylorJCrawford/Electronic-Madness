using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Madness
{
    [Serializable]
    class StoreUserClass
    {
        private UserClass[] usersarray;

        public StoreUserClass()
        {
            usersarray = new UserClass[1];
        }

        public int Usercounter
        {
            get { return usersarray.Length-1; }
        }

        public bool CheckuserData(string email, string username, string password01, string password02)
        {
            int min = 8;
            bool tester = false;
            bool usernametester = false;
            UserClass tempobjec = new UserClass();

            usernametester = checkuser(username);
            if (usernametester == false)
            {
                MessageBox.Show("Username has been used or has not been entered:");
            }
            else
            {
                if (email.Contains('@'))
                {
                    tester = true;
                    if (password01.Length > min)
                    {
                        tester = true;
                        if (password01 == password02)
                        {
                            tester = true;
                        }
                        else
                        {
                            MessageBox.Show("Passwords are not the same!");
                            tester = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Password Needs to be more than 8 charters");
                        tester = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid email");
                    tester = false;
                }
            }

            return tester;
        }

        public void Adduser(UserClass newuser) //0= emterpy
        {
            usersarray[usersarray.Length - 1] = newuser;
                Array.Resize(ref usersarray, usersarray.Length + 1);

        }

        //This is getting the index number of the user, based on the username.
        public int getuser(string username)
        {
            UserClass tempu;
            bool found = false;
            int index = Usercounter;

            while (index > 0 && found == false)
            {
                tempu = usersarray[index - 1];
                if (tempu.Username == username)
                    found = true;
                else
                    index--;
            }
            index--;
            return index;
        }


        //Method to check that the username has not be used.
        public bool checkuser(string username01)
        {
            bool test = true;
            UserClass tempuser=null; //create an emtey object
            //Program.LoadObject(ref tempuser);
            if (Usercounter == 0)
            {
                MessageBox.Show("There is no user");
            }
            else
            {
                
                for (int i = 0; i < Usercounter; i++)
                {
                    if (tempuser != null)
                    {
                        tempuser = usersarray[i]; //reading and copying the object to the temp object.
                        if (tempuser.Username == username01) //checking
                        {
                            test = false;
                            MessageBox.Show("Username has been used"); //ass resu
                        }
                    }
                }
            }
            return test;
        }

        //Method to check the username and password match.
        public bool checkuserpass(string username01, string password01)
        {
            int index = 0;
            bool test = false;
            UserClass tempuser; //create an emtey object

            while (index < Usercounter)
            {
                tempuser = usersarray[index]; //reading and copying the object to the temp object.
                if (tempuser.Username == username01 && tempuser.Password == password01) //checking
                {
                    test = true;
                }
                else if (tempuser.Username == username01 && tempuser.Password != password01 || tempuser.Password == password01 && tempuser.Username != username01)
                {
                    MessageBox.Show("The Username & Password do not match");
                }
                else if (tempuser.Username != username01 && tempuser.Password != password01)
                {
                    MessageBox.Show("The user doesn't exist");
                }
                index++;
            }
            return test;
        }

        //Adding top users to listbox...
        public void listoftop_5_players(ref ListBox top_players_listbox)//Not working/ dont understand
        {
            //StoreUserClass userarray01= null;
            //Program.LoadObject(ref userarray01);
            
            UserClass user02 = null;     //= new UserClass();
            int usercouter01 = Usercounter + 1; //beacuse slot 1 in the array is null

            if (usercouter01 == 0)
            {
                MessageBox.Show("There is no user to display in listbox"); //The Program jumpes to this...
            }
            else
            {
                MessageBox.Show("Test");
                int num = 5;
                if (Usercounter < 5) num = usercouter01;

                Array.Sort(usersarray); //Large to small
                
                for (int i = 0; i < num; i++)
                {
                    MessageBox.Show("+1"); //Testing
                    user02 = usersarray[i];
                    //Here!!!!
                    string user_display = Convert.ToString(user02.Highestpoints + "" + user02.Username);
                    top_players_listbox.Items.Add(user_display);
                }
            }
        }

        //This method will update the user if the user scored more than his hight score 
        public void update_userspoints(string username, int points)
        {
            //check user is there {To Do}{To Add}

            int userindex = getuser(username); //get user

            usersarray[userindex].Highestpoints = points; //Update users points
        }

    }
}
