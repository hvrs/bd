using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimp.Forms
{
    public partial class addAplication : Form
    {
        public addAplication()
        {
            InitializeComponent();
        }
        public static string email = "";
        private void addAplication_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Сотрудники", "Клиенты", "Поставщики", "Продукция", "Заявки", "Списанное" });
            comboBox2.Items.AddRange(new string[] { "Добавить", "Удалить", "Изменить", "Поиск", "Сортировка", "Фильтрация" });
            
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)//На главную
        {
            MainPage mainPage = new MainPage();
            MainPage.email = email;
            mainPage.Show();
            this.Close();
        }

        private void btn_toAcc_Click(object sender, EventArgs e)
        {
            accPage acc = new accPage();
            accPage.email = email;
            acc.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainPage.email = "";
            email = "";
            accPage.email = "";
            MainPage.Sign = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1 && comboBox1.SelectedIndex > -1)
            {
                work_with_tables wwt = new work_with_tables();
                work_with_tables.login = email;
                work_with_tables.table = comboBox1.Text;
                work_with_tables.action = comboBox2.Text;
                wwt.Show();
                this.Close();
            }
        }
    }
}
