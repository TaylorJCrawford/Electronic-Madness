using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Madness
{
    class QuestionsClass
    {
        private int questionfrmcheker;
        private int timeleft;

        public QuestionsClass()
        {
        questionfrmcheker = 0;
        timeleft = 300;
        }

        public QuestionsClass(int tempquestionfrmcheker)
        {
            questionfrmcheker = tempquestionfrmcheker;
        }

        public int Questionfrmcheker
        {
            get { return questionfrmcheker;}
            set { questionfrmcheker = value; }
        }

        //Methods---------------------------------------------------------------

        //Could increase the numbers and do if || more ||
        public int Randomnumber_gen()
        {
            Random numberGenerator = new Random();

            int num01 = numberGenerator.Next(1, 10); //10);
            return num01;
        }

        //This method open question forms based on the rb buttons.
        public void mainmenuchosse(UserClass playinguser)
        {
            switch (questionfrmcheker)
            {
                case 1:
                    {
                        frmeasy_q1 tempopen01 = new frmeasy_q1(playinguser);
                        tempopen01.Show();
                        break;
                    }
                case 2:
                    {
                        
                        frmhard_q1 tempopen02 = new frmhard_q1(playinguser);
                        tempopen02.Show();
                        break;
                    }
                case 3:
                    {
                        frmnormal_q1 tempopen03 = new frmnormal_q1(playinguser);
                        tempopen03.Show();
                        break;
                    }
            }
        }

        //Load question to form...
        public void easyquestion1()
        {
            int numberofq = Randomnumber_gen();

            if (numberofq == 1)
            {
                //load image of ...
            }
            else if (numberofq == 2)
            {
                //load image of...
            }
        }
        
        public string questiontimer()
        {
            string lbltimer;
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                lbltimer= timeleft + " Seconds ";
            }
            else
            {
                lbltimer = "";
                //MessageBox.Show("You didn't finish in time. ", "Sorry!");
            }
            return lbltimer;
        }

        public void loadhelp_page(int formnum, UserClass playing_user)
        {
            
            switch (formnum)
            {
                case 1:
                    {
                        frmeasy_q1 nextform = new frmeasy_q1(playing_user); //pass in the form name as a parmeter and access the method to load the form
                        nextform.Show();
                    } break;

                case 2:
                    {
                        frmeasy_q2 nextform = new frmeasy_q2(playing_user);
                        nextform.Show();
                    } break;

                case 3:
                    {
                        frmeasy_q3 nextform = new frmeasy_q3(playing_user);
                        nextform.Show();
                    } break;

                case 4:
                    {
                        frmnormal_q1 nextform = new frmnormal_q1(playing_user);
                        nextform.Show();
                    } break;

                case 5:
                    {
                        frmnormal_q2 nextform = new frmnormal_q2(playing_user);
                        nextform.Show();
                    } break;

                case 6:
                    {
                        frmnormal_q3 nextform = new frmnormal_q3(playing_user);
                        nextform.Show();
                    } break;

                case 7:
                    {
                        frmhard_q1 nextform = new frmhard_q1(playing_user);
                        nextform.Show();
                    } break;

                case 8:
                    {
                        frmhard_q2 nextfrom = new frmhard_q2(playing_user);
                        nextfrom.Show();
                    } break;

                case 9:
                    {
                        frmhard_q3 nextfrom = new frmhard_q3(playing_user);
                        nextfrom.Show();
                    } break;
            }
           
        }

        //This method was a smaller version of the code for checking the answer
        //public int questionone_easy(int question_answer, int submit_answer, int gamemode) //question one checker
        //{
        //    //key for gamemode
        //    //1- easy q
        //    //2- 


        //    //key for tempkey
        //    //1- right
        //    //2- wrong 
        //    //3- not answed
        //    //bool nextform= false; 

        //    int tempkey = 3;

        //    if (submit_answer == question_answer)
        //    {
        //        MessageBox.Show("You are right, you have gained 2 points!");
        //        tempkey = 1;
        //    }
        //    else if (submit_answer == 3)
        //    {
        //        MessageBox.Show("You need to select an answer!");
        //    }
        //    else
        //    {
        //        tempkey = 2;
        //        MessageBox.Show("Sorry you are wrong, you have lost 1 point!");
        //    }
        //    return tempkey;



        //}
    }
}
