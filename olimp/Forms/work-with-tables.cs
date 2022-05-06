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
    public partial class work_with_tables : Form
    {
        public work_with_tables()
        {
            InitializeComponent();
        }
        public static string table;
        public static string action;
        public static string login;
        private void work_with_tables_Load(object sender, EventArgs e)
        {
            button1.Visible = true; button1.Text = "Выполнить";
            if (action == "Добавить")
            {
                
                if (table == "Сотрудники")
                {
                    label1.Text = "Фамилия";
                    label2.Text = "Имя";
                    label3.Text = "Отчество";
                    label4.Text = "Номер телефона";
                    label5.Text = "Банковский счет";
                    label6.Text = "Заработная плата";
                    label7.Text = "Пол";
                    label8.Text = "Паспортные данные";
                    label9.Text = "ИНН";
                    label10.Text = "Должность";
                    label11.Visible = false;
                    textBox11.Visible = false;
                }
                else if (table == "Клиенты")
                {
                    //label1.Text = "Номер клиента";
                    label1.Text = "Фамилия";
                    label2.Text = "Имя";
                    label3.Text = "Отчество";
                    label4.Text = "Номер телефона";
                    label5.Text = "Номер бонусной карты";

                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                else if (table == "Поставщики")
                {
                    label1.Text = "Код поставщика";
                    label2.Text = "Название компании";
                    label3.Text = "Специализация товара";

                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                else if (table == "Продукция")
                {
                    label1.Text = "Номер продукта";
                    label2.Text = "Название";
                    label3.Text = "Количество продукции";
                    label4.Text = "Стоимость продукции";
                    label5.Text = "Код поставщика";

                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                else if (table == "Заявки")
                {
                    label1.Text = "Код заявки";
                    label2.Text = "Название";
                    label3.Text = "Количество";
                    label4.Text = "Стоимость заказа";
                    label5.Text = "Код поставщика";

                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                else if (table == "Списанное")
                {
                    label1.Text = "ID";
                    label2.Text = "Номер продукта";
                    label3.Text = "Количество";
                    label4.Text = "Убыток";

                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
            }
            else if (action == "Удалить")
            {
                tb_del.Visible = true;
                button1.Visible = true;
                button1.Text = "Удалить";
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                if (table == "Сотрудники")
                {
                    
                }
                else if (table == "Клиенты")
                {

                }
                else if (table == "Поставщики")
                {

                }
                else if (table == "Продукция")
                {

                }
                else if (table == "Заявки")
                {

                }
                else if (table == "Списанное")
                {

                }
            }
            else if (action == "Изменить")
            {
                if (table == "Сотрудники")
                {
                   
                    label1.Text = "Фамилия";
                    label2.Text = "Имя";
                    label3.Text = "Отчество";
                    label4.Text = "Номер телефона";
                    label5.Text = "Банковский счет";
                    label6.Text = "Заработная плата";
                    label7.Text = "Пол";
                    label8.Text = "Паспортные данные";
                    label9.Text = "ИНН";
                    label10.Text = "Должность";
                    textBox11.Visible = false;
                }
                if (table == "Клиенты")
                {
                    label1.Text = "Номер клиента";
                    label2.Text = "Фамилия";
                    label3.Text = "Имя";
                    label4.Text = "Отчество";
                    label5.Text = "Номер телефона";
                    label6.Text = "Номер бонусной карты";

                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                if (table == "Поставщики")
                {
                    label1.Text = "Код поставщика";
                    label2.Text = "Название компании";
                    label3.Text = "Специализация товара";

                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                if (table == "Продукция")
                {
                    label1.Text = "Номер продукта";
                    label2.Text = "Название";
                    label3.Text = "Количество продукции";
                    label4.Text = "Стоимость продукции";
                    label5.Text = "Код поставщика";

                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                if (table == "Заявки")
                {
                    label1.Text = "Код заявки";
                    label2.Text = "Название";
                    label3.Text = "Количество";
                    label4.Text = "Стоимость заказа";
                    label5.Text = "Код поставщика";

                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
                if (table == "Списанное")
                {
                    label1.Text = "ID";
                    label2.Text = "Номер продукта";
                    label3.Text = "Количество";
                    label4.Text = "Убыток";

                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox11.Visible = false;

                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                }
            }
            else if (action == "Поиск")
            {
                dataGridView1.Visible = true;
                tb_del.Visible = true;
                button1.Visible = true; button1.Text = "Поиск";
                lbl_untxt.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                if (table == "Сотрудники")
                {
                    lbl_untxt.Text = "Фамилия";
                }
                else if (table == "Клиенты")
                {
                    lbl_untxt.Text = "Фамилия";
                }
                else if (table == "Поставщики")
                {
                    lbl_untxt.Text = "Название компании";
                }
                else if (table == "Продукция")
                {
                    lbl_untxt.Text = "Название";
                }
                else if (table == "Заявки")
                {
                    lbl_untxt.Text = "Название";
                }
                else if (table == "Списанное")
                {
                    lbl_untxt.Text = "ID";
                }
            }
            else if (action == "Сортировка")
            {
                dataGridView1.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                if (table == "Сотрудники")
                {

                }
                else if (table == "Клиенты")
                {

                }
                else if (table == "Поставщики")
                {

                }
                else if (table == "Продукция")
                {

                }
                else if (table == "Заявки")
                {

                }
                else if (table == "Списанное")
                {

                }
            }
            else if (action == "Фильтрация")
            {
                tb_del.Visible = true; tb_del2.Visible = true;
                dataGridView1.Visible = true;
                button1.Visible = true; button1.Text = "Фильтрация";
                if (table == "Сотрудники")
                {

                }
                else if (table == "Клиенты")
                {

                }
                else if (table == "Поставщики")
                {

                }
                else if (table == "Продукция")
                {

                }
                else if (table == "Заявки")
                {

                }
                else if (table == "Списанное")
                {

                }
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            MainPage.email = login;
            MainPage.Sign = true;
            mainPage.Show();
            this.Close();
        }

        private void btn_toAcc_Click(object sender, EventArgs e)
        {
            accPage acc = new accPage();
            accPage.email = login;
            acc.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MainPage.email = "";
            MainPage.Sign = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectToDatabase cTb = new connectToDatabase();
        }
    }
}
