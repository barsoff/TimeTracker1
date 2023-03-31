using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker1.DataBase;
using TimeTracker1.AuthClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeTracker1
{
    public partial class FormRegister : Form
    {

        private ClassDataBase database;

        private bool isClose = true; // Флаг для того, чтобы приложение не закрывалось при закрытии формы
        public FormRegister()
        {
            InitializeComponent();
        }

        private void labelGoToLogForm_Click(object sender, EventArgs e)
        {
            isClose = false;
            this.Close();
            this.Owner.Show();
        }


        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string script = "";
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            if (!Regex.IsMatch(textBox6.Text, ".+@.+\\.[a-z]+"))
            {
                MessageBox.Show("Электронная почта введена в неверном формате");
                return;
            }
            var res = database.SelectFunctionUsing("autorization.\"user\" u where '" + textBox1.Text.Trim() + "' = u.login");
            res.Read();
            if (res.HasRows)
            {
                MessageBox.Show("Пользователь с данным логином существует!");
                res.Close();
                return;
            }
            res.Close();
            script += "do $$ declare v_iduser int8; begin insert into autorization.user (firstname, lastname, middlename, phone, email,disabled, login, password) values ('" + textBox7.Text.Trim() + "','" + textBox8.Text.Trim() + "', '" + textBox4.Text.Trim() + "', '" + textBox5.Text.Trim() + "', '" + textBox6.Text.Trim() + "',true, '" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "') returning user_id into v_iduser;";
            script += "insert into public.user (first_name, last_name, middle_name, phone, email, disabled, login, password) values('" + textBox7.Text.Trim() + "','" + textBox8.Text.Trim() + "', '" + textBox4.Text.Trim() + "', '" + textBox5.Text.Trim() + "', '" + textBox6.Text.Trim() + "', true, '" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "');";
            script += "insert into autorization.connect_user_role (user_id, role_id) values (v_iduser, 2);";
            script += "insert into public.connect_user_role (user_id, role_id) values (v_iduser, 2);";
            script += "end;$$";
            if (!string.IsNullOrEmpty(script))
            {
                database.ExecuteScript(script);
                MessageBox.Show("Пользователь создан!");
            }
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
        public void SetDB(ClassDataBase _db)
        {
            this.database = _db;
        }

    }
}