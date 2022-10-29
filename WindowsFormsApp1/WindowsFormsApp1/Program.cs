using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Exit();

            /*using(TextFieldParser tfp=new TextFieldParser(@"F:\Zadanie\DocumentItems.csv"))
            {
                tfp.TextFieldType=FieldType.Delimited;
                while(!tfp.EndOfData)
                {
                    string[] fileds = tfp.ReadFields();
                }

            }*/
        }
    }
}
