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

namespace CGS_Win
{
    public partial class Login : Form
    {
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\joann\Documents\LaSalleCollege_Pratic\ThirdSem\Multi-tierApp\Projects\CGS_Classes\txtFile\login.txt"))
            {
                bool flag = false;

                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();
                    strArray = str.Split(',');

                    if (username_textbox.Text == strArray[0] && password_textbox.Text == strArray[1])
                    {
                        flag = true;
                    }
                }

                if(flag == true) {
                    mainForm cgsArt = new mainForm();
                    this.Hide();
                    cgsArt.Visible = true;
                    cgsArt.Activate();
                }
                else if (username_textbox.Text == "")
                {
                    MessageBox.Show("Error! Enter Username.");
                }
                else if (password_textbox.Text == "")
                {
                    MessageBox.Show("Error! Enter Password.");
                }
                else
                {
                    if (count < 2)
                    {
                        MessageBox.Show("Wrong username and password. Try again");
                        count++;
                        username_textbox.Clear();
                        password_textbox.Clear();
                    }
                    else
                    {
                        if (MessageBox.Show("You exceeded the number of tries", "ERROR!", MessageBoxButtons.OK).ToString() == "OK")
                            Application.Exit();
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
