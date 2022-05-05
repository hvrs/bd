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
            if (action == "Добавить")
            {


                if (table == "Сотрудники")
                {
                    label1.Text = "Табельный номер";
                    label2.Text = "Фамилия";
                    label3.Text = "Имя";
                    label4.Text = "Отчество";
                    label5.Text = "Номер телефона";
                    label6.Text = "Банковский счет";
                    label7.Text = "Заработная плата";
                    label8.Text = "Пол";
                    label9.Text = "Паспортные данные";
                    label10.Text = "ИНН";
                    label11.Text = "Должность";
                }
                else if (table == "Клиенты")
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
                if (table == "Сотрудники")
                {
                    tb_del.Visible = true;
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
    }
}
