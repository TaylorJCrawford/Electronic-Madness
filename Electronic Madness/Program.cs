using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Electronic_Madness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoading_Form());
        }


        //This is saving the object.
        public static void SaveObject(StoreUserClass thisobject)
        {
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            sw = File.Open("mydata.dat", FileMode.Create);
            bf.Serialize(sw, thisobject);
            sw.Close();
        }

        //This is loading the object.
        public static void LoadObject(ref StoreUserClass thisobject)
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            sr = File.OpenRead("mydata.dat");
            thisobject = (StoreUserClass)bf.Deserialize(sr);
            sr.Close();
        }
    }
}
