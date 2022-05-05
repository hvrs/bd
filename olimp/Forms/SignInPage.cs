using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using olimp.Forms;
using System.Text.RegularExpressions;

namespace olimp
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            bool isUser = true;          
            string password = "";
            if (tb_Email.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Введите Email";
                return;
            }          
            else if (tb_Pasw.Text == string.Empty)
            {
                lbl_typeErr.Visible = true;
                lbl_typeErr.Text = "Введите пароль";
                return;
            }
            else
            {
                connectToDatabase connectToDatabase = new connectToDatabase(); 
                connectToDatabase.signin(tb_Email.Text, out password, out isUser);
            }
            if (password.ToLower() == tb_Pasw.Text.ToLower() && isUser == true)
            {
                MainPage.email = tb_Email.Text;
                MainPage.Sign = true;
                accPage accPage = new accPage();
                accPage.email = tb_Email.Text;
                addAplication.email = tb_Email.Text;
                accPage.Show();
                this.Close();
            }
            else
            {
                lbl_typeErr.Visible = true; lbl_typeErr.Text = "Неверный пароль или логин";
            }
        }

     
    }
}
