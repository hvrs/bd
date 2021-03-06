
namespace olimp
{
    partial class SignInPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Pasw = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_typeErr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Pasw
            // 
            this.tb_Pasw.Location = new System.Drawing.Point(23, 83);
            this.tb_Pasw.Name = "tb_Pasw";
            this.tb_Pasw.PasswordChar = '*';
            this.tb_Pasw.Size = new System.Drawing.Size(159, 20);
            this.tb_Pasw.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(23, 34);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(159, 20);
            this.tb_Email.TabIndex = 2;
            // 
            // lbl_typeErr
            // 
            this.lbl_typeErr.AutoSize = true;
            this.lbl_typeErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_typeErr.Location = new System.Drawing.Point(33, 118);
            this.lbl_typeErr.Name = "lbl_typeErr";
            this.lbl_typeErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_typeErr.TabIndex = 5;
            this.lbl_typeErr.Text = "label1";
            this.lbl_typeErr.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login:";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btn_SignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(0, 0);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(205, 39);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.Text = "Войти";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 39);
            this.panel1.TabIndex = 9;
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(205, 186);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_typeErr);
            this.Controls.Add(this.tb_Pasw);
            this.Controls.Add(this.tb_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pasw;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_typeErr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Panel panel1;
    }
}