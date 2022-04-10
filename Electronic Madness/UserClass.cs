using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Madness
{
    [Serializable]
    public class UserClass: IComparable<UserClass>
    {
        private string username;
        private string password;
        private string email;
        private int points;
        private int highestpoints;

        public UserClass()
        {
            username = "";
            password = "";
            email = "";
            points= 0;
        }

        public UserClass(string tempusername, string temppassword, string tempemail, int temppoints, int temphighestpoints)
        {
            username = tempusername;
            password = temppassword;
            email = tempemail;
            points = temppoints;
            highestpoints = temphighestpoints;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public int Highestpoints
        {
            get { return highestpoints; }
            set { highestpoints = value; }
        }

        public int CompareTo(UserClass p)
        {
            //return string.Compare(this.Name, p.Name);
            if (this.highestpoints > p.highestpoints)
                return 1;
            else if (this.highestpoints < p.highestpoints)
                return -1;
            else
                return 0;
        }
    }
}
